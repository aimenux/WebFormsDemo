using System.Data.Entity;
using WebApp2.Models;

namespace WebApp2.DataAccess
{
    public class DatabaseContextInitializer : DropCreateDatabaseAlways<SchoolDbContext>
    {
        protected override void Seed(SchoolDbContext context)
        {
            base.Seed(context);
            context.Students.Add(new Student {Id = 1, Name = "John", Age = 20, BirthCity = "Madrid"});
            context.Students.Add(new Student {Id = 2, Name = "Paul", Age = 25, BirthCity = "London"});
            context.Students.Add(new Student {Id = 3, Name = "Fred", Age = 23, BirthCity = "Berlin"});
            context.Students.Add(new Student {Id = 4, Name = "Nico", Age = 21, BirthCity = "Vienna"});
            context.Students.Add(new Student {Id = 5, Name = "Aude", Age = 26, BirthCity = "Mexico"});
            context.Students.Add(new Student {Id = 6, Name = "Sara", Age = 24, BirthCity = "Napoli"});
        }
    }
}