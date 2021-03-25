using System;
using System.Collections.Generic;
using System.Text;
using Exercise01.Models;

namespace Exercise01.Interfaces
{
    public interface IEmployeeService
    {
        public Programmer GetProgrammer(string EmployeeID);
    }
}
