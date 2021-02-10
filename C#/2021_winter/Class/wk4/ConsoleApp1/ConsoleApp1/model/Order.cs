using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    public class Order
    {

        public string OrderID { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public double Total { 
            get{
                double total = 0;
                if(this.Items != null){
                    foreach(var item in this.Items)
                        total += item.Product.Price * item.Quantity;
                }
                return total;
                    
            }
        }

        private Order(){
            this.OrderID = Guid.NewGuid().ToString();
            this.Items = new List<OrderItem>();
        }

        public static Order CreateOrder(Customer customer, Product product, int quantity = 1){
            var order = new Order();
            order.Customer = customer;

            var item = new OrderItem(product, quantity);
            order.Items.Add(item);

            return order;
        }

        public override string ToString()
        {
            return $"Order ID: {this.OrderID} \n"+
                $"Customer: {this.Customer.FirstName} {this.Customer.LastName}\n" +
                $"Total: {this.Total}";
        }


    }
}
