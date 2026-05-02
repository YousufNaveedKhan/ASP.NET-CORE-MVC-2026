using Microsoft.AspNetCore.Mvc;

namespace lec03_ConventionBasedRouting.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
