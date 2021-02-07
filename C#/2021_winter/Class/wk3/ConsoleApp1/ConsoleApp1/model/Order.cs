using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    class Order
    {
        public string OrderID { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public double Total { get; set; }
    }
}
