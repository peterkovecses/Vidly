using Microsoft.EntityFrameworkCore;
using Vidly.Models;

namespace Vidly.Seed
{
    public class TestDataConfiguration
    {
        public static void ConfigureSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType { Id = 1, SignUpFee = 0, DurationInMonths = 0, DiscountRate = 0 },
                new MembershipType { Id = 2, SignUpFee = 30, DurationInMonths = 1, DiscountRate = 10 },
                new MembershipType { Id = 3, SignUpFee = 90, DurationInMonths = 3, DiscountRate = 15 },
                new MembershipType { Id = 4, SignUpFee = 300, DurationInMonths = 12, DiscountRate = 20 }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Tim", IsSubscribedForNewsletter = true, MembershipTypeId = (byte)1 },
                new Customer { Id = 2, Name = "Tom", IsSubscribedForNewsletter = true, MembershipTypeId = (byte)2 },
                new Customer { Id = 3, Name = "Tod", IsSubscribedForNewsletter = false, MembershipTypeId = (byte)3 },
                new Customer { Id = 4, Name = "Jane", IsSubscribedForNewsletter = true, MembershipTypeId = (byte)4 }
                );
        }
    }
}
