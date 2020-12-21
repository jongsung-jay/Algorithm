using System;

namespace Question02
{
    /*
     * Write a console-based program that prompts a user for an hourly pay rate. 
     * If the value entered is less than $7.50 or greater than $49.99, display an error message; 
     * otherwise, display a message indicating that the rate is okay.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double rate;
            Console.Write("Input an hourly pay rate : ");
            rate = Convert.ToDouble(Console.ReadLine());

            if(rate < 7.50 || rate > 49.99)
            {
                Console.WriteLine("Error : the rate is wrong... ");
            }
            else
            {
                Console.WriteLine("the rate is okay");
            }
            Console.ReadKey();
        }
    }
}
