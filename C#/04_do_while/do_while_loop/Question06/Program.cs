using System;

namespace Question06
{
    class Program
    {
        /*
         * To repeatedly prompt for a number and sum it. When the sum just exceeds 100, 
         * stop the prompting and display the sum at the end. You must not display the sum while the user in typing in numbers. 
         * (You do not need a counter but you will need some way of terminating the loop)
         */
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            do
            {
                Console.Write($"Enter a number[{i}]: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                i++;
            } while (sum <= 100);
            Console.WriteLine(sum);
        }
    }
}
