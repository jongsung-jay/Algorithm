using System;

namespace Question07
{
    class Program
    {
        // Write a Program to compute the average of ten numbers which will be entered by the user.
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.Write("Enter a number[{0}] : ", i);
                int num = Convert.ToInt32(Console.ReadLine());

                sum = sum + num;
            }
            Console.WriteLine(sum/10);
        }
    }
}
