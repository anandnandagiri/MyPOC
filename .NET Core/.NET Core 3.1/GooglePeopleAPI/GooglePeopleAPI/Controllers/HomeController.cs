using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GooglePeopleAPI.Models;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;
using System.Threading;
using GooglePeopleAPI.Helpers;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Auth.OAuth2.Requests;
using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.Configuration;

namespace GooglePeopleAPI.Controllers
{                                   

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }                     

        //public async Task<IActionResult> IndexAsync()
        //{
        //    string m_client_secret = _config.GetValue<string>("GooglePoepleAPI:ClientSecret");
        //    string m_client_id = _config.GetValue<string>("GooglePoepleAPI:ClientId");            


        //    UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
        //                                        new ClientSecrets
        //                                        {
        //                                            ClientId = m_client_id,
        //                                            ClientSecret = m_client_secret
        //                                        },
        //                                        new[] { "profile", "https://www.googleapis.com/auth/contacts.readonly","https://www.googleapis.com/auth/user.birthday.read", "https://www.googleapis.com/auth/user.emails.read" },
        //                                        "user",
        //                                        CancellationToken.None,
        //                                        null,
        //                                        new GoogleLocalServerCodeReceiver()).Result;

        ////Anand Revoke your token to test Google GoogleLocalServerCodeReceiver
        ////https://accounts.google.com/o/oauth2/revoke?token=ya29.Il-7B-FNEf9yuyksKfTsIRC80H7ePCKW_h5uI6DWFJua0AretnfCrNw3nFwH_WhWrbhzoFpfe2JHbiHiNtE8uKmp3pbn6uCR1qL2mVfFhxxdDmZfECTXQGwEYiAucWN_mg

        //    var service = new PeopleServiceService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = "VAapps",
        //    });


        //    ContactGroupsResource groupsResource = new ContactGroupsResource(service);
        //    ContactGroupsResource.ListRequest listRequest = groupsResource.List();
        //    ListContactGroupsResponse response = listRequest.Execute();


        //    List<string> listOnView = new List<string>();
        //    foreach (ContactGroup group in response.ContactGroups)
        //    {
        //        listOnView.Add("Groups: " + group.FormattedName);
        //    }

        //    PeopleResource.ConnectionsResource.ListRequest peopleRequest = service.People.Connections.List("people/me");
        //    peopleRequest.PersonFields = "names,emailAddresses,phoneNumbers";
        //    peopleRequest.SortOrder = (PeopleResource.ConnectionsResource.ListRequest.SortOrderEnum)1;
        //    ListConnectionsResponse people = peopleRequest.Execute();

        //    _ = await credential.RevokeTokenAsync(CancellationToken.None);

        //   // Process.Start(new ProcessStartInfo("cmd", $"/c start \"\" \"{url}\"") { CreateNoWindow = true });           



        //    ViewBag.ContactList = people.Connections;
        //    return View();
        //}

    }
}
