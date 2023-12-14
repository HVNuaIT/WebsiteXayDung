using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebsiteXayDung.Application.Response;
using WebsiteXayDung.MVC.Models;

namespace WebsiteXayDung.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var hienThi = new TestValuse();
            ViewBag.Hello = hienThi.Name;
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
