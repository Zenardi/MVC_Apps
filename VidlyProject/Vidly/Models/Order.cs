using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Controllers;

namespace Vidly.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime DeliverDate { get; set; }
        public int ProductId { get; set; }

        public Customer[] GetClients()
        {
            return new OrderController().GetCustomersName();
        }
    }
}