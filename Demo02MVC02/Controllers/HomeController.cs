using Microsoft.AspNetCore.Mvc;

namespace Demo02MVC02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); //HTML Pages
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContcatUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
