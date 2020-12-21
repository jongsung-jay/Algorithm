using System;
/*
 * Write a program that calculates the tax on an item, based on the province code. 
 * Your program will prompt the user for the 2-letter province code, 
 * and the cost of the item and then computes the tax based on the following table:
 *      Province	            Rate
            ON	                14%
            PQ	                13%
    Any other province	         0%

 */
namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the 2-letter province code: ");
            string code = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            
            if(code == "ON")
            {
                double tax = price * 0.14;
                double cost = price + tax;
                Console.WriteLine($"Code : {code}, price : {price:c2}, tax : {tax:c2}, cost : {cost:c2}");
            }
            else if(code == "PQ")
            {
                double tax = price * 0.13;
                double cost = price + tax;
                Console.WriteLine($"Code : {code}, price : {price:c2}, tax : {tax:c2}, cost : {cost:c2}");
            }
            else
            {
                double tax = price * 0;
                double cost = price + tax;
                Console.WriteLine($"Code : {code}, price : {price:c2}, tax : {tax:c2}, cost : {cost:c2}");
            }
        }
    }
}
