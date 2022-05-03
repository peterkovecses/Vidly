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
                new Customer { Id = 1, Birthdate = new DateTime(1976, 11, 22), Name = "Tim", IsSubscribedForNewsletter = true, MembershipTypeId = (byte)1 },
                new Customer { Id = 2, Birthdate = new DateTime(1983, 01, 18), Name = "Tom", IsSubscribedForNewsletter = true, MembershipTypeId = (byte)2 },
                new Customer { Id = 3, Birthdate = null, Name = "Tod", IsSubscribedForNewsletter = false, MembershipTypeId = (byte)3 },
                new Customer { Id = 4, Birthdate = new DateTime(1989, 04, 22), Name = "Jane", IsSubscribedForNewsletter = true, MembershipTypeId = (byte)4 }
                );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Thriller" },
                new Genre { Id = 3, Name = "Family" },
                new Genre { Id = 4, Name = "Romance" },
                new Genre { Id = 5, Name = "Comedy" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Terminator", GenreId = (byte)1 },
                new Movie { Id = 2, Title = "Terminator2", GenreId = (byte)1 },
                new Movie { Id = 3, Title = "Rambo", GenreId = (byte)1 },
                new Movie { Id = 4, Title = "Rambo 2", GenreId = (byte)1 },
                new Movie { Id = 5, Title = "Rambo 3", GenreId = (byte)1 },
                new Movie { Id = 6, Title = "Oscar", GenreId = (byte)5 }

                );
        }
    }
}
