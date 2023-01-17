using Backend.Models.DtoModels;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAcces
{
    public class UniversityContext: DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options): base(options) 
        {

        }
        public DbSet <User>  Users { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
