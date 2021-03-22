using System;
using System.Collections.Generic;
using Exercise01.Interfaces;
using Exercise01.Models;
using Exercise01.Service;

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

            // interface
            Console.WriteLine("\n-----------------------------------------------\n");

            IEmployeeService employeeService = new EmployeeService();

            var programmer = employeeService.GetProgrammer("emp001");
            programmer.Work();
        }
    }
}
