using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Classes
{
    public class Person
    {
        // properties
        public string FirstName { get; set; }

        // method
        public Person(string name)
        {
            this.FirstName = name;
        }
        public void Speak()
        {
            Console.WriteLine("Hello!!");
        }
    }
}
