using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    class OrderItem
    {
        public string OrderItemID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { 
            get{
                if(this.Product != null)
                    return this.Product.Price * this.Quantity;
                else
                    return 0;
            } 
        }

        public OrderItem(Product product, int quantity = 1){
            this.OrderItemID = Guid.NewGuid().ToString();
            this.Product = product;
            this.Quantity = quantity;
            return Order;
        }
    }
}
