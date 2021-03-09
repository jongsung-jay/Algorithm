using System;
using System.Collections.Generic;
using Exercise01.Models;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee salesPerson = new SalesPerson() { 
                EmployeeID = "SALES01",
                FirstName = "John",
                LastName = "Smith"
            };

            Employee genitor = new Genitor() { 
                EmployeeID = "GEN01",
                FirstName = "Steve",
                LastName = "Johnson"
            };

            salesPerson.ClockIn();
            genitor.ClockIn();

            Console.WriteLine("\n-----------------------------------------------\n");
            salesPerson.Work();
            genitor.Work();

            Console.WriteLine("\n-----------------------------------------------\n");
            salesPerson.ReceivePay();
            genitor.ReceivePay();
        }
    }
}
