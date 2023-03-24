using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webhost;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webhost)
        {
            _logger = logger;
            _webhost = webhost;
        }

        public IActionResult Index()
        {
            List<string> list = new List<string>();

            list.Add($"Enviroment : {Environment.ProcessPath}");
            list.Add($"IWeb Content : {_webhost.ContentRootPath}");
            list.Add($"IWeb Web : {_webhost.WebRootPath}");
            list.Add($"Process Main Module Current Path: {Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)}");
            //list.Add($"Process Start Current Path: {Path.GetDirectoryName(Process.GetCurrentProcess().StartInfo.FileName)}");
            list.Add($"Process . Current Path: {Path.GetDirectoryName(".")}");
            list.Add($"");
            list.Add($"");
            list.Add($"");
            ViewBag.Path = list;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}