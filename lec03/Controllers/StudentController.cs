using Microsoft.AspNetCore.Mvc;
using lec03.Data;
using lec03.Models;

namespace lec03.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Content("Data saved successfully!");
        }
    }
}