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
            Desktop gaming = new("Gaming Rig", 1500, 16);
            Desktop office =new("Office Rig", 700, 8);
            Desktop development = new("Development Rig", 2500, 32);
            ViewData["Message"] = "Desktop Computers for sale";
            return View(new Desktop[] {gaming, office, development});
        }

        public IActionResult Laptops()
        {
            ViewData["Message"] = "Laptop and tablet Computers for sale";
            ViewData["saleMessage"] = "All laptop are 10% of this week";

            Laptop[] list = {new Laptop("Surface Pro", 2500, 16, 15, 3),
            new("Ipad", 1600, 8, 15, 3),
            new("Del Inspiron", 800, 16, 17, 6),
            new Laptop("Red Laptop", 1200, 32, 15, 8)};
            return View(list);
        }

        public IActionResult OrderForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderForm(OrderItem theOrder)
        {
            if (ModelState.IsValid)
            {
                AllOrders.AddOrder(theOrder);
                return View("Thanks", theOrder);
            }
            else
            {
                return View(theOrder);
            }
            
        }

        public IActionResult ShowOrders()
        {
            return View(AllOrders.ListOrders);
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