using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GoogleOAuth.Models;
using Microsoft.AspNetCore.Authorization;

namespace GoogleOAuth.Controllers
{
    public class OtherDocsController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}