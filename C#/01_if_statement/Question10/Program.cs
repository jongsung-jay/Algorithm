using System;
/*
 * Write a console-based program that prompts a user for an hourly pay rate. 
 * If the user enters values less than $7.50 or greater than $49.99, prompt the user again. 
 * If the user enters an invalid value again, display an appropriate error message. 
 * If the user enters a valid value on either the first or second attempt, 
 * display the pay rate as well as the weekly rate, which is calculated as 40 times the hourly rate. 
 */
namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double rate;
            Console.Write("Enter an hourly pay rate: ");
            rate = Convert.ToDouble(Console.ReadLine());

            // output
            double weekly_rate;

            // algorithm
            if(rate < 7.50 || rate > 49.99)
            {
                Console.Write("Enter an hourly pay rate again...: ");
                rate = Convert.ToDouble(Console.ReadLine());
                if(rate >= 7.50 && rate <= 49.99)
                {
                    weekly_rate = rate * 40;
                    Console.WriteLine($"Your rate : {rate:c2}, Your weekly rate : {weekly_rate:c2}");
                }
                else
                {
                    Console.WriteLine("Sorry..You entered wrong number...");
                }
            }
            else
            {
                weekly_rate = rate * 40;
                Console.WriteLine($"Your rate : {rate:c2}, Your weekly rate : {weekly_rate:c2}");
            }
            Console.ReadKey();
        }
    }
}
