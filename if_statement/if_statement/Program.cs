using System;

namespace question01
{
    /*
     * Write a console-based program that prompts the user for an hourly pay rate. 
     * If the value entered is less than $7.50, display an error message
     */
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            Console.Write("Enter the value($) : ");
            value = Convert.ToDouble(Console.ReadLine());

            if(value < 7.50)
            {
                Console.WriteLine("Error : the value is wrong... ");
            }
            else
            {
                Console.WriteLine($"Your value is {value:c2}");
            }
            Console.ReadKey();
        }
    }
}
