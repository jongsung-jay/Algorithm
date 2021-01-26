using System;

namespace Question06
{
    class Program
    {
        /*
         * Write a Program to compute the total of eight numbers
         */
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            for (i = 1; i < 9; i++)
            {
                sum = i+ sum;     
            }
            Console.WriteLine(sum);
        }
    }
}
