using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly VidlyDbContext _dbContext;

        public CustomersController(VidlyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var customers = _dbContext.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = _dbContext.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return View(customer);
        }

        public IActionResult New()
        {
            var membershipTypes = _dbContext.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypesSelectList = new SelectList(membershipTypes, "Id", "Name")
            };       
            return View("CustomerForm", viewModel);
        }       

        public IActionResult Edit (int id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypesSelectList = new SelectList(_dbContext.MembershipTypes.ToList(), "Id", "Name")
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public IActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
                _dbContext.Customers.Add(customer);

            else
            {
                var customerInDb = _dbContext.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.IsSubscribedForNewsletter = customer.IsSubscribedForNewsletter;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
            }

            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }
    }
}
