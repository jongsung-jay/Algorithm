using System;

namespace Question10
{
    class Program
    {
        /*
         * A machine purchased for $28,000 depreciates at a rate of $4,000 a year for seven years. 
         * Write and run a C# program that computes and displays a depreciation table for seven years. 
         * The table should have the form: 
                                       END-OF-YEAR         ACCUMULATED
            YEAR      DEPRECIATION        VALUE           DEPRECIATION
            ----      ------------      ------------      ------------
             1            4000            24000               4000
             2            4000            20000               8000
             3            4000            16000              12000
             4            4000            12000              16000
             5            4000             8000              20000
             6            4000             4000              24000
             7            4000                0              28000

         */
        static void Main(string[] args)
        {
            int i = 1;
            int machine = 28000;
            int rate = 4000;
            int rate1 = 4000;
            Console.WriteLine("YEAR  DEPRECIATIO  END-OF-YEAR VALUE  ACCUMUKATED DEPRECIATION");
            Console.WriteLine("------------------------------------------------------------------------");
            do
            {
                int value = machine - rate;
                machine = value;
                Console.WriteLine($"{i}\t{rate}\t\t{value,5}\t\t\t{rate1,5}");
                rate1 += rate;
                i++;
            } while (i <= 7);
        }
    }
}
