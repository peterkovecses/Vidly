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
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<MusicAlbum> MusicAlbums { get; set; }
        public DbSet<MusicGenre> MusicGenres { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            TestDataConfiguration.ConfigureSeedData(modelBuilder);
        }
    }
}
