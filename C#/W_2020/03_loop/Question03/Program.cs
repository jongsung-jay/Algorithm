using System;

namespace Question03
{
    class Program
    {
        /*
         * Write a C# program that converts gallons to liters. 
         * The program should display gallons from 10 to 20 in one-gallon increments and the corresponding liter’ equivalents. 
         * Use the relationship that 1 gallon contains 3.785 liters.
         */
        static void Main(string[] args)
        {
            // 1 gallon = 3.785 liters
            int i;
            double liter;
            Console.WriteLine("gallons\t\tliter");
            Console.WriteLine("-----------------------");
            for (i = 10; i <= 20; i++)
            {
                liter = i * 3.785;
                Console.WriteLine(" {0}\t\t{1:f2}", i,liter);
            }
        }
    }
}
