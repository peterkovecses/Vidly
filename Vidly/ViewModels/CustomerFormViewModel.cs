using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public SelectList MembershipTypesSelectList { get; set; }       
    }
}
