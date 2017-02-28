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
            var clients = _context.Customers.ToList();
            var products = _context.Product.ToList();

            var viewModel = new OrderFormViewModel
            {
                Customers = clients,
                Products = products
            };


            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Order formViewModel)
        {
            _context.Order.Add(formViewModel);
            _context.SaveChanges();

            return RedirectToAction("Index", "Order");
        }
    }
}