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
            // Employee employee = new Employee(); //employee 슈퍼 클래스를 abstract로 해주면 삭제한후 밑의 클래스들을 저렇게 쓰는게 가능해짐
            Employee salesPerson = new SalesPerson() { // salesPerson은 항상 employee가되지만 employee는 항상 salesPerson이 되지 않음 so, Employee salesPerson = new SalesPerson(); 이게 가능한것
                EmployeeID = "SALES01",
                FristName = "John",
                LastName = "Smith"
            }; 

            Employee genitor = new Genitor() {
                EmployeeID = "GEN01",
                FristName = "Steve",
                LastName = "Johnson",
                Shift = Shift.Night
            };

            //List<Employee> list = new List<Employee>();
            //list.Add(salesPerson); //employee와 salesperson이 같게됨

            salesPerson.ClockIn();
            salesPerson.Clockout();

            Console.WriteLine("\n========================================================\n");
            salesPerson.Work();
            genitor.Work();
            Console.WriteLine("\n========================================================\n");
            salesPerson.ReceivePay();
            genitor.ReceivePay();

            // ---------------------------------8WK---------------------------------------------------

            IFrontEndProgrammer frontEndProgrammer = new Programmer();
            frontEndProgrammer.DesignGUI();
            Console.WriteLine("\n========================================================\n");

            IEmployeeService employeeService = new EmployeeService();
            var programmer = employeeService.GetProgrammer("emp001");
            programmer.Work();

            Console.WriteLine("\n========================================================\n");
            IEmployeeService employeeService1 = new NewEmployeeService();
            var programmer1 = employeeService1.GetProgrammer("emp001");
            programmer1.Work();


        }
    }

}
