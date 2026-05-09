using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lec01.Models;

namespace lec01.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        ViewBag.age = 15;
        return View();
    }
}
