using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidly.Controllers;
using Vidly.Models;
using WebGrease;

namespace Vidly.ViewModels
{
    public class OrderFormViewModel
    {
        public int Id { get; set; }
        public DateTime ReferenceDate { get; set; }

        public String CustomerName { get; set; }

        public String ProductName { get; set; }
        public float ProductUnitCost { get; set; }

        public int Quantity { get; set; }
        public float TotalValue { get; set; }


        //public IEnumerable<Customer> Customers;
    }
}