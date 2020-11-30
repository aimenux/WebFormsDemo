using System.Data.Entity;
using WebApp3.Models;

namespace WebApp3.DataAccess
{
    public interface ISchoolDbContext
    {
        DbSet<Student> Students { get; set; }
    }
}