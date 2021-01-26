using System;

namespace Question11
{
    class Program
    {
        /*
         * Write and run a C# program that calculates and displays the amount of money available in a bank account 
         * that initially has $1,000 deposited in it and that earns 8 percent interest a year. 
         * Your program should display the amount available at the end of each year for a period of ten years.
         * Use the relationship that the money available at the end of each year equals the amount of money in the account 
         * at the start of the year plus .08 times the amount available at the start of the year.
         */
        static void Main(string[] args)
        {
            double deposit = 1000;
            double interest = 0.08;
            int i = 0;

            Console.WriteLine(" yesr\t\tamout of money");
        
            while (i <= 10)
            {
                Console.WriteLine($" {i,2}\t\t{deposit:f2}");
                deposit = deposit + (deposit * interest);
                i++;
            }
        }
    }
}
