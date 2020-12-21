using System;

namespace Question12
{
    class Program
    {
        /*
         * Write a program that prompts a user for an hourly pay rate. 
         * If the user enters values less than $5.65 or greater than $49 99, prompt the user again.
         * If the user enters an invalid value again, display an appropriate error message. 
         * If the user enters a valid value on either the first or second attempt, 
         * display the pay rate as well as the weekly rate which calculated as 40 times the hourly rate 
         */
        static void Main(string[] args)
        {
            int caseinfo = 1;
            Console.Write("Enter an hourly pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            switch (caseinfo)
            {
                case 1:
                    if(rate < 5.65 || rate > 49.99)
                    {
                        Console.Write("Enter an hourly pay rate again: ");
                        rate = Convert.ToDouble(Console.ReadLine());
                        if (rate < 5.65 || rate > 49.99)
                        {
                            Console.WriteLine("Error! Invalid input");
                        }
                        else
                        {
                            Console.WriteLine($"hourly rate : {rate:f2}, weekly rate : {rate*40:f2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"hourly rate : {rate:f2}, weekly rate : {rate * 40:f2}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
