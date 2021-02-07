using System;
using ConsoleApp1.model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(19.99, "Lamp");
            product.ShippingMethod = ShippingMethod.LocalPickup;

            Console.WriteLine(product);
        }
    }
}
