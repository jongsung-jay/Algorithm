using System;
using ConsoleApp2.Classes;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring an object
            //Person colin;

            // Initializing an object
            //colin = new Person();

            // Declare and initialize
            Person colin = new Person("colin");

            //colin.FirstName = "Colin";

            colin.Speak();
            Console.WriteLine(colin.FirstName);
           
        }
    }
}
