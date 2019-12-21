using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoogleOAuth.Controllers
{
    public class GCPLinksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}