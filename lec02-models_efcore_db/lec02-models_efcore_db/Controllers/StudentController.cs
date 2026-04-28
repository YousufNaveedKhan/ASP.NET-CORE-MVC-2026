using Microsoft.AspNetCore.Mvc;
using lec02_models_efcore_db.Data;
using lec02_models_efcore_db.Models;

namespace lec02_models_efcore_db.Controllers
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
