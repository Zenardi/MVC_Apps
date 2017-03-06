using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult Index()
        {
            var prod = GetProducts();

            return View(prod);
        }

        private IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Description = "Prod1" },
                new Product { Id = 2, Description = "Prod2" }
            };
        }

    }


}