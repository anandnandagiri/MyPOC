using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Responses;
using System.Threading;
using Google.Apis.Services;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;
using Microsoft.Extensions.Configuration;


namespace GooglePeopleAPI.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IConfiguration _config;

        public PeopleController(IConfiguration config)
        {
            _config = config;
        }


        public async Task<IActionResult> Index()
        {
            string gCode = Request.Query["code"].ToString();
            TempData["code"] = gCode;
            HttpContext.Items["code"] = gCode;
            //return await Index(gCode);
            return RedirectToAction("Contact");
        }


        public async Task<IActionResult> Contact()
        {
            string gCode = TempData["code"].ToString();
            string ClientSecret = _config.GetValue<string>("GooglePoepleAPI:ClientSecret");
            string ClientId = _config.GetValue<string>("GooglePoepleAPI:ClientId");

            string userId = "userId";
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
                  "http://localhost:5000/people/", // redirect_uri can not be empty. Must be one of the redirects url listed in your project in the api console
                  CancellationToken.None);
            }

            UserCredential userCredential = new UserCredential(authorizationCodeFlow, userId, tokenResponse);

            var service = new PeopleServiceService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = userCredential,
                ApplicationName = "VAapps",
            });


            ContactGroupsResource groupsResource = new ContactGroupsResource(service);
            ContactGroupsResource.ListRequest listRequest = groupsResource.List();
            ListContactGroupsResponse response = listRequest.Execute();


            List<string> listOnView = new List<string>();
            foreach (ContactGroup group in response.ContactGroups)
            {
                listOnView.Add("Groups: " + group.FormattedName);
            }

            Google.Apis.PeopleService.v1.PeopleResource.ConnectionsResource.ListRequest peopleRequest = service.People.Connections.List("people/me");
            peopleRequest.PersonFields = "names,emailAddresses,phoneNumbers";
            peopleRequest.SortOrder = (Google.Apis.PeopleService.v1.PeopleResource.ConnectionsResource.ListRequest.SortOrderEnum)1;
            peopleRequest.PageSize = 1999;
            ListConnectionsResponse people = peopleRequest.Execute();


            //      are: * addresses * ageRanges * biographies * birthdays * braggingRights * coverPhotos
            //     * emailAddresses * events * genders * imClients * interests * locales * memberships
            //     * metadata * names * nicknames * occupations * organizations * phoneNumbers *
            //     photos * relations * relationshipInterests * relationshipStatuses * residences
            //     * sipAddresses * skills * taglines * urls * userDefined

            var me = service.People.Get("people/me");
            me.PersonFields = "names,emailAddresses,phoneNumbers,birthdays,coverPhotos,metadata,events";
            var aboutMe = me.Execute();
            ViewBag.AboutMe = aboutMe;
            
          


            ViewBag.ContactList = people.Connections;
            return View();
        }

    }
}