using Microsoft.EntityFrameworkCore;
using lec02_models_efcore_db.Models;

namespace lec02_models_efcore_db.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}