using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;

        public OrderController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Order
        public ActionResult Index()
        {
            ViewBag.CustomersList = GetCustomersName();
            ViewBag.ProductList = GetProductsList();
            return View();
        }

        [HttpPost]
        public ActionResult Save(Order formViewModel)
        {
            _context.Order.Add(formViewModel);
            _context.SaveChanges();

            return RedirectToAction("Index", "Order");
        }

        public Customer[] GetCustomersName()
        {
            var customersName = _context.Customers.ToArray();

            return customersName;
        }

        public Product[] GetProductsList()
        {
            var products = _context.Product.ToArray();

            return products;
        }
    }
}