using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.model
{
    class Customer
    {
        // fields

        // properties
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Oders { get; set; }

        // method
        private Customer(string firstName, string lastName, string email)
        {
            this.CustomerID = Guid.NewGuid().ToString(); // guid: unique key
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"Customer ID: {this.CustomerID} \n" +
                $"Name: {this.FirstName} {this.LastName} \n" +
                $"Email: {this.Email} \n" +
                $"Phone: {this.PhoneNumber}";
        }

        public static Customer CreateCustomer(string firstName, string lastName, string email){
            Customer customer = new Customer(firstName, lastName, email);
            
            // Do some fancy validation here...

            return customer;
        }
    }
}
