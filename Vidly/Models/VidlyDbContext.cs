using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Vidly.Models
{
    public class VidlyDbContext : DbContext
    {
        public VidlyDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
