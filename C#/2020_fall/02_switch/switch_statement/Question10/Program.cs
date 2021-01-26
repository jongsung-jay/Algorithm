using System;

namespace Question10
{
    class Program
    {
        /*
         * Write a program that prompts the user or an hourly pay rate. 
         * If the value entered is less than $5 65, display an error message
         */
        static void Main(string[] args)
        {
            int caseinfo = 1;
            Console.Write("Enter an hourly pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            switch (caseinfo)
            {
                case 1:
                    if(rate < 5.65)
                    {
                        Console.WriteLine("error...");
                    }
                    else
                    {
                    Console.WriteLine(rate);
                    }
                break;
                default:
                    break;
            }
        }
    }
}
