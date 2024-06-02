using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DataBase
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Survey> Surveys { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { 
            Database.EnsureCreated();
        }

    }
}
