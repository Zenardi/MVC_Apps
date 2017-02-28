using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DeliverDate { get; set; }
        public long SerialNumber { get; set; }
        public Customer Customer { get; set; }
        public float Total { get; set; }
        public IEnumerable<OrderItems> Items { get; set; }
        
    }
}