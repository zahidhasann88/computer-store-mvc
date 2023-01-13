using computerstore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace computerstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Desktops()
        {
            ViewData["Message"] = "Desktop Computers for sale";
            return View(new string[] {"Gaming Desktop", "Office Desktop", "Development Desktop"});
        }

        public IActionResult Laptops()
        {
            ViewData["Message"] = "Laptop and tablet Computers for sale";
            ViewData["saleMessage"] = "All laptop are 10% of this week";
            return View();
        }

        public IActionResult Index()
        {
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