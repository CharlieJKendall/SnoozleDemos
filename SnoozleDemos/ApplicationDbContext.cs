using Microsoft.EntityFrameworkCore;
using SnoozleDemos.RestResources;
using System.Reflection;

namespace SnoozleDemos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
