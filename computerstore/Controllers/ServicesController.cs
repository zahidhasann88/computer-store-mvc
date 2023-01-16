using Microsoft.AspNetCore.Mvc;

namespace computerstore.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Repair()
        {
            return View();
        }
    }
}
