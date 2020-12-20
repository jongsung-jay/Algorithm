using System;

namespace Question07
{
    /*
     * The average cost of a college textbook is $125. 
     * There is a premium of 20% on hardcover text and a discount of 5% on sales of more than 4 textbooks. 
     * Write a program to prompt the user for the appropriate inputs and compute and display the before-tax cost of the textbooks.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int average_cost = 125;
            double premium = 0.2;
            double discount = 0.05;
            double price;
            Console.Write("Enter the value: ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.Write("Are the books hardcover true/false: ");
            bool hardcover = Convert.ToBoolean(Console.ReadLine());

            if (hardcover == true)
            {
                if(value > 4)
                {
                    price = value * average_cost + premium - discount;
                }
                else
                {
                    price = value * average_cost + premium;
                }
            }
            else{
                if(value > 4){
                    price = value * average_cost - discount;
                }
                else
                {
                    price = value * average_cost;
                }
            }
            Console.WriteLine($"Before-tax cost of the textbooks: {price:c2}");

        }
    }
}
