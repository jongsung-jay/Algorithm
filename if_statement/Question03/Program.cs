using System;

namespace Question03
{
    /*
     * If money is left in a particular bank for more than 5 years, 
     * the interest rate given by the bank is 7.5%, else the interest rate is 5.4%. 
     * Write a program that prompt the user for the number of years that the money was left in the bank 
     * and display the appropriate interest rate depending on the value input. 
     * How many runs should you make to very that it works correctly?
     */
    class Program
    {
        static void Main(string[] args)
        {
            double value, years, money;
            Console.Write("Enter the value: ");
            value = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of years: ");
            years = Convert.ToDouble(Console.ReadLine());

            if(years > 5)
            {
                money = value * years * 0.075;
                Console.WriteLine($"year is {years}, rate is 7.5%, money is {money:c2}");
            }
            else
            {
                money = value * years * 0.054;
                Console.WriteLine($"year is {years}, rate is 5.4%, money is {money:c2}");
            }
        }
    }
}
