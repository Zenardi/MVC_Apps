using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class OrderFormViewModel
    {
        public int Id { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public Customer Customer { get; set; }

        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }

        public DateTime Date { get; set; }

        public int Quantity { get; set; }

    }
}