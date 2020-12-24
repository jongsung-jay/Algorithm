using System;

namespace Question04
{
    class Program
    {
        /*
         * Write a C# program that converts feet to meters. 
         * The program should display feet from 3 to 30 in three-foot increments and the corresponding meter equivalents. 
         * Use the relationship that 1 meter is equivalent to 3.28 feet. 
         */
        static void Main(string[] args)
        {
            // 1meter = 3.28feet
            int i;
            double feet;
            Console.WriteLine("meter\t\tfeet");
            Console.WriteLine("-----------------------");
            for (i = 3; i <= 30; i += 3)
            {
                feet = i * 3.28;
                Console.WriteLine(" {0}\t\t{1:f2}", i, feet);
            }
        }
    }
}
