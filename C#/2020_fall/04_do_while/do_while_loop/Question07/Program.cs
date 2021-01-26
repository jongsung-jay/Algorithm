using System;

namespace Question07
{
    class Program
    {
        /*
         * Same as the previous question but additionally displays the average of the numbers when the loop terminates. 
         * You will need a counter but not as a loop terminator.
         */
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            double average;
            do
            {
                Console.Write($"Enter a number[{i}]: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                i++;
            } while (sum <= 100);
            average = sum / (i-1);
            Console.WriteLine($"sum : {sum}, average : {average}");
        }
    }
}
