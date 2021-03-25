using System;
using System.Collections.Generic;
using System.Text;
using Exercise01.Interfaces;
using Exercise01.Models;

namespace Exercise01.Service
{
    public class NewEmployeeService : IEmployeeService
    {
        public Programmer GetProgrammer(string EmployeeID)
        {
            // Connecting to HR System...
            // HRsystem request came bavk with the object below
            Console.WriteLine("Retrieving object from HR...");
            var employee = new Programmer()
            {
                EmployeeID = EmployeeID,
                FristName = "Bruce",
                LastName = "Wayne",
                HireDate = new DateTime(2015, 07, 01),
                Position = "Programmer",
                Salary = 1200000
            };
            return employee;
        }
    }
}
