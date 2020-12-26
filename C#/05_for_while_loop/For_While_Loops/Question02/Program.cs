using System;

namespace Question02
{
    class Program
    {
        /*
         * Write a Program to compute the sum of eight numbers. You will prompt the user for each number. 
         * Your prompt should also indicate which number is currently being accepted 
         * e.g. your prompt can be "Please enter value #5: "
         */
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            for (i = 1; i <= 8; i++)
            {
                Console.Write($"Please enter value #{i}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);        
        }
    }
}
