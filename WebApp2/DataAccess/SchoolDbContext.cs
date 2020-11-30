using System.Data.Entity;
using WebApp2.Models;

namespace WebApp2.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<SchoolDbContext>(new DatabaseContextInitializer());
        }
    }
}