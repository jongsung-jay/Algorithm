using System;

namespace Question12
{
    class Program
    {
        /*
         * A machine purchased for $28,000 is depreciated at a rate of $4,000 a year for seven years. 
         * Write and run a C program that computes and displays a depreciation table for seven years, 
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
            //int value = 28000;
            int year = 1, depreciation = 4000, endOfYearValue = 24000, accumulatedDepreciation = 4000; 
            Console.WriteLine("year depreciation endOfYearValue accumulatedDepreciation"); 
            Console.WriteLine("---- ------------ --------------- -----------------------");

            do
            {
                Console.WriteLine($"{year}\t{depreciation}\t\t{endOfYearValue,5}\t\t{accumulatedDepreciation,5}");
                endOfYearValue = endOfYearValue - depreciation;
                accumulatedDepreciation = accumulatedDepreciation + depreciation;
                year++;
            } while (year <= 7);
        }
    }
}
