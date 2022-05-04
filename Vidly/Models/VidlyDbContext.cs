using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Vidly.Seed;

namespace Vidly.Models
{
    public class VidlyDbContext : DbContext
    {
        public VidlyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            TestDataConfiguration.ConfigureSeedData(modelBuilder);
        }
    }
}
