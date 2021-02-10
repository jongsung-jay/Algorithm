using System;
using ConsoleApp1.model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var customer =  Customer.CreateCustomer("John", "Smith", "john@smith.com");
            var product = Product.CreateProduct(99.99, "Sword");
            var order = order.CreateOrder(customer, product);

            Console.WriteLine(order);


            
        }
    }
}
