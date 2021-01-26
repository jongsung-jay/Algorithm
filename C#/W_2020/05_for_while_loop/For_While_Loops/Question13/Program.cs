using System;

namespace Question13
{
    class Program
    {
        /*
         * Write a program to reverse the digits of a positive integer number. 
         * For example, if the number 8735 is entered, the number displayed should be 5378. 
         * (Hint: Use a do statement and continuously strip off and display the units digit of the number. 
         * If the variable num initially contains the number entered, the units digit is obtained as (num % 10). 
         * After a units digit is displayed, dividing the number by 10 sets up the number for the next iteration. 
         * Thus, (8735 % 10) is 5 and (8735 / 10) is 873. 
         * The do statement should continue as long as the remaining number is not zero).
         */
        static void Main(string[] args)
        {
            int number, counter = 1;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("{0}", number % (int)Math.Pow(10, counter));
                number = number / (int)Math.Pow(10, counter);
                counter++;
            } while (number % (int)Math.Pow(10, counter) != 0);

        }
    }
}
