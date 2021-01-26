using System;

namespace Question04
{
    class Program
    {
        /*
         * Write a C# program that displays a conversion table from gallons to liters. 
         * The program should display gallons from 10 to 20 in one-gallon increments and the corresponding liter equivalents. 
         * Use the relationship that 1 gallon contains 3.785 liters. Your table must look professional!
         */
        static void Main(string[] args)
        {
            Console.WriteLine(" gallons\tliters");
            Console.WriteLine("------------------------");

            // 1 gallon = 3.785 liters
            int gallon;
            double liters;
            for (gallon = 10; gallon <= 20; gallon++)
            {
                liters = gallon * 3.785;
                Console.WriteLine($"  {gallon}\t\t{liters:f2}");
            }
        }
    }
}
