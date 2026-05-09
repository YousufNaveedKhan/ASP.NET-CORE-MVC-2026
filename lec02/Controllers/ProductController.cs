using Microsoft.AspNetCore.Mvc;

namespace lec02.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        ViewBag.title = "Product Page";
        return View();
    }
    public IActionResult Details()
    {
        ViewBag.title = "Product Details Page";
        return View();
    }
}
