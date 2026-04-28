using Microsoft.AspNetCore.Mvc;

namespace lec01_introduction.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}