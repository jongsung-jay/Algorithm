using System;

namespace Question05
{
    class Program
    {
        /*
         * Write a C# program that converts feet to meters. 
         * The program should display feet from 3 to 30 in three-foot increments and the corresponding meter equivalents. 
         * Use the relationship that 1 meter is equivalent to 3.28 feet. Your table must look professional!
         */
        static void Main(string[] args)
        {
            int feet;
            double meter;
            Console.WriteLine(" feet\t\tmeter");
            Console.WriteLine("------------------------");
            for(feet = 3; feet <= 30; feet++)
            {
                meter = feet * 3.28;
                Console.WriteLine($"  {feet,2}\t\t{meter:f2}");
            }
        }
    }
}
