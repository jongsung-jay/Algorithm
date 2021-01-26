using System;

namespace Question12
{
    class Program
    {
        /*
         * Write a program to compute the (x, y) pairs for the equation y = 2x2 –x  - 6 for x in the range 1 to 5 
         * in 0.5 increments.
            x	 2x2	-x	-6	 y
            1.0	 2.0	-1.0	-6	-5.0
            1.5	 4.5	-1.5	-6	-3.0
            2.0	 8.0	-2.0	-6	 0.0
            2.5	12.5	-2.5	-6	 4.0

         */
        static void Main(string[] args)
        {
            Console.WriteLine("x\t2x^2\t-x\t-6\ty");
            Console.WriteLine("-----------------------------------------");

            for(double i = 1; i < 5; i += 0.5)
            {
                double second = 2 * i * i;
                double third = -i;
                double y = second + third - 6;
                Console.WriteLine("{0:f1}\t{1,4:f1}\t{2,4:f1}\t-6\t{3,4:f1}", i, second, third, y);
            }
        }
    }
}
