﻿using System;
using System.Collections.Generic;
using System.Text;
using Exercise01.Interfaces;
using Exercise01.Models;

namespace Exercise01.Service
{
    public class EmployeeService : IEmployeeService
    {
        public Programmer GetProgrammer(string employeeID)
        {
            //Retrieving employee object from database...
            // ...
            // Database request came back with the object below
            Console.WriteLine("Retrieving object from database...");
            var employee = new Programmer()
            {
                EmployeeID = employeeID,
                FirstName = "Bruce",
                LastName = "Wayne",
                HireDate = new DateTime(2015, 07, 01),
                Position = "Programmer",
                Salary = 120000
            };
            return employee;
        }
    }
}
