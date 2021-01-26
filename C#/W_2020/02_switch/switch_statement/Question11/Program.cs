using System;

namespace Question11
{
    class Program
    {
        /*
         * Write a program that prompts a user for an hourly pay rate. 
         * If the value entered is less than $5 65 or greater than $49 99, display an error message 
         */
        static void Main(string[] args)
        {
            int CaseRate = 1;
            Console.Write("Enter an hourly pay rate: ");
            int rate = Convert.ToInt32(Console.ReadLine());

            switch (CaseRate)
            {
                case 1:
                    if(rate < 5.65 || rate > 49.99)
                    {
                        Console.WriteLine("Error...");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
