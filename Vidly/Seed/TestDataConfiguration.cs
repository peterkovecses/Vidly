using Microsoft.EntityFrameworkCore;
using System;
using Vidly.Models;

namespace Vidly.Seed
{
    public class TestDataConfiguration
    {
        public static void ConfigureSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType { Id = 1, Name = "Pay as You Go", SignUpFee = 0, DurationInMonths = 0, DiscountRate = 0 },
                new MembershipType { Id = 2, Name = "Monthly", SignUpFee = 30, DurationInMonths = 1, DiscountRate = 10 },
                new MembershipType { Id = 3, Name = "Quarterly", SignUpFee = 90, DurationInMonths = 3, DiscountRate = 15 },
                new MembershipType { Id = 4, Name = "Annual", SignUpFee = 300, DurationInMonths = 12, DiscountRate = 20 }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Birthdate = new DateTime(1976, 11, 22), Name = "Tim", IsSubscribedForNewsletter = true, MembershipTypeId = MembershipType.PayAsYouGo },
                new Customer { Id = 2, Birthdate = new DateTime(1983, 01, 18), Name = "Tom", IsSubscribedForNewsletter = true, MembershipTypeId = MembershipType.Monthly },
                new Customer { Id = 3, Birthdate = null, Name = "Tod", IsSubscribedForNewsletter = false, MembershipTypeId = MembershipType.Quarterly },
                new Customer { Id = 4, Birthdate = new DateTime(1989, 04, 22), Name = "Jane", IsSubscribedForNewsletter = true, MembershipTypeId = MembershipType.Annual }
                );

            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre { Id = 1, Name = "Action" },
                new MovieGenre { Id = 2, Name = "Thriller" },
                new MovieGenre { Id = 3, Name = "Family" },
                new MovieGenre { Id = 4, Name = "Romance" },
                new MovieGenre { Id = 5, Name = "Comedy" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Terminator", GenreId = (byte)1, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1984, 2, 1), NumberInStock = (byte)15 },
                new Movie { Id = 2, Title = "Terminator2", GenreId = (byte)1, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1991, 2, 1), NumberInStock = (byte)15 },
                new Movie { Id = 3, Title = "Rambo", GenreId = (byte)1, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1982, 2, 1), NumberInStock = (byte)15 },
                new Movie { Id = 4, Title = "Rambo 2", GenreId = (byte)1, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1985, 2, 1), NumberInStock = (byte)15 },
                new Movie { Id = 5, Title = "Rambo 3", GenreId = (byte)1, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1988, 2, 1), NumberInStock = (byte)15 },
                new Movie { Id = 6, Title = "Oscar", GenreId = (byte)5, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1991, 2, 1), NumberInStock = (byte)15 }
                );

            modelBuilder.Entity<MusicGenre>().HasData(
                new MovieGenre { Id = 1, Name = "Rock" },
                new MovieGenre { Id = 2, Name = "Jazz" },
                new MovieGenre { Id = 3, Name = "Heavy Metal" },
                new MovieGenre { Id = 4, Name = "Rap/Hip Hop" },
                new MovieGenre { Id = 5, Name = "Electronic" },
                new MovieGenre { Id = 6, Name = "Country" },
                new MovieGenre { Id = 7, Name = "Soul/R&B" }
                );

            modelBuilder.Entity<MusicAlbum>().HasData(
                new MusicAlbum { Id = 1, Artist = "Metallica", Title = "Kill 'Em All", GenreId = (byte)3, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1983, 7, 25), NumberInStock = (byte)15 },
                new MusicAlbum { Id = 2, Artist = "Metallica", Title = "Ride the Lightning", GenreId = (byte)3, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1984, 7, 27), NumberInStock = (byte)15 },
                new MusicAlbum { Id = 3, Artist = "Metallica", Title = "Master of Puppets", GenreId = (byte)3, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1986, 3, 3), NumberInStock = (byte)15 },
                new MusicAlbum { Id = 4, Artist = "Metallica", Title = "...And Justice for All", GenreId = (byte)3, DateAdded = new DateTime(2022, 05, 04), ReleaseDate = new DateTime(1988, 9, 7), NumberInStock = (byte)15 }
                );
        }
    }
}
