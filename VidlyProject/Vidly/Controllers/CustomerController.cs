using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            //_context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            //_context.Dispose();
        }

        public ViewResult Index()
        {
            //var customers = _context.Customers.ToList();
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(String id)
        {
            //var customer =_context.Customers.SingleOrDefault(c => c.Id == id);
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = "1", Name = "John Smith" },
                new Customer { Id = "2", Name = "Mary Williams" }
            };
        }

    }
}