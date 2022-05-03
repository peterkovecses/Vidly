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
                ); ;
        }
    }
}
