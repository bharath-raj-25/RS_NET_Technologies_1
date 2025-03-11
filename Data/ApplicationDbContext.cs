using Microsoft.EntityFrameworkCore;
using RSTechnologiesWeb.Models;

namespace RSTechnologiesWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=RSTechnologiesDb;user=root;password=Balu@1234;",
                    ServerVersion.AutoDetect("server=localhost;database=RSTechnologiesDb;user=root;password=Balu@1234;"));
            }
        }
    }
}
