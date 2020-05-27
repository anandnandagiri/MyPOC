using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CalenderApp.Controllers
{
    public class GoogleController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public GoogleController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            string gCode = Request.Query["code"].ToString();
            TempData["code"] = gCode;
            return RedirectToAction("Calender");
        }
        public async Task<IActionResult> Calender()
        {
            string gCode = TempData["code"].ToString();
            TempData.Keep("code");

            string ClientSecret = _config.GetValue<string>("GoogleCalenderAPI:ClientSecret");
            string ClientId = _config.GetValue<string>("GoogleCalenderAPI:ClientId");

            string userId = Guid.NewGuid().ToString();
            if (TempData["userId"] == null)
            {
                TempData["userId"] = userId;
            }
            else
            {
                userId = TempData["userId"].ToString();
                TempData.Keep("userId");
            }

            const string dataStoreFolder = "googleApiStorageFile";

            // create authorization code flow with clientSecrets
            GoogleAuthorizationCodeFlow authorizationCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                DataStore = new FileDataStore(dataStoreFolder),
                ClientSecrets = new ClientSecrets()
                {
                    ClientId = ClientId,
                    ClientSecret = ClientSecret
                }
            });

            FileDataStore fileStore = new FileDataStore(dataStoreFolder);
            TokenResponse tokenResponse = await fileStore.GetAsync<TokenResponse>(userId);

            if (tokenResponse == null)
            {
                // token data does not exist for this user
                tokenResponse = await authorizationCodeFlow.ExchangeCodeForTokenAsync(
                  userId, // user for tracking the userId on our backend system
                  gCode,
#if DEBUG
                   "https://localhost:5001/google/",
#else
                  "https://calender.vaapps.com/google/", // redirect_uri can not be empty. Must be one of the redirects url listed in your project in the api console
#endif
                  CancellationToken.None);
            }


            UserCredential userCredential = new UserCredential(authorizationCodeFlow, userId, tokenResponse);

            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = userCredential,
                ApplicationName = "VAapps",
            });

            GoogleCalendar("primary", service);
            GoogleCalendar("en.indian#holiday@group.v.calendar.google.com", service);                    

            return View();
        }

        private void GoogleCalendar(string calendarID, CalendarService service)
        {
            Console.WriteLine();
            Console.WriteLine("*****************************");
            Console.WriteLine(calendarID);
            Console.WriteLine("*****************************");

            EventsResource.ListRequest request = service.Events.List(calendarID);
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 100;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.Updated;

            // List events.
            Events events = request.Execute();
            Console.WriteLine("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    Console.WriteLine("{0} ({1})", eventItem.Summary, when);
                }
            }
            else
            {
                Console.WriteLine("No upcoming events found.");
            }
        }


    }
}