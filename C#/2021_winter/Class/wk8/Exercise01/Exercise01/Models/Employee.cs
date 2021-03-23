using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01.Models
{
    public abstract class Employee
    {
        public string EmployeeID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }

        public void ClockIn() {
            Console.WriteLine($"{this.EmployeeID} clocked in");
        }

        public void Clockout() {
            Console.WriteLine($"{this.EmployeeID} clocked out");
        }

        public abstract void Work(); // abstract method cannot have body

        public virtual void ReceivePay() {
            Console.WriteLine("Just got paid!");
        }

        private void Quit() { 
            // 다른 클래스에서 접근하기위해서는 private이 아닌 protected를 사용하면 됨. 상속경우.
        }
    }
}
