using System.ComponentModel.DataAnnotations;

namespace lec02_models_efcore_db.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
