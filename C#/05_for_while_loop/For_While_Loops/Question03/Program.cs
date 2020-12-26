using System;

namespace Question03
{
    class Program
    {
        /*
         * Write a Program to compute the average of ten numbers. You will prompt the user for each number.
         */
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            double average;
            for(i = 0; i < 8; i++)
            {
                Console.Write($"Enter a number[{i + 1}]: ");
                int num = Convert.ToInt32(Console.ReadLine());

                sum += num;
            }
            average = sum / i;
            Console.WriteLine($"sum : {sum}, average : {average:f2}");
        }
    }
}
