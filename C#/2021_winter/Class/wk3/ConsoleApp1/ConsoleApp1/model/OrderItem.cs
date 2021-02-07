using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    class OrderItem
    {
        public string OrserItemID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
    }
}
