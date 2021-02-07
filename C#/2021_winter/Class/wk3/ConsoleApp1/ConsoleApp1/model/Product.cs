using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    class Product
    {
        // Field
        private int stock;

        // properties
        public string ProductID { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsInStock {
            get {
                return this.stock > 0;
            }
        }
        public ShippingMethod ShippingMethod { get; set; }

        // Methods
        public Product(double price, string description)
        {
            this.ProductID = Guid.NewGuid().ToString();
            this.Price = price;
            this.Description = description;
        }

        public override string ToString()
        {
            return $"Product ID: {this.ProductID} \n" +
                   $"Description: {this.Description} \n" +
                   $"Price: {this.Price:C} \n" +
                   $"Stock: {this.stock} \n" +
                   $"Shipping Method: {this.ShippingMethod}";
        }

    }
}
