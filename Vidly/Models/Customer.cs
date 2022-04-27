﻿using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedForNewsletter { get; set; }

        public byte MembershipTypeId { get; set; } // Foreign Key
        public MembershipType MembershipType { get; set; } // Navigation Property
    }
}
