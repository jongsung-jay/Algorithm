using System;

namespace Question08
{
    class Program
    {
        /*
         * Write a program that displays a conversion table from Fahrenheit to Celsius. 
         * The program must request the starting Fahrenheit value, the ending Fahrenheit value, and the increment. 
         * Thus, instead of the condition checking for a fixed count, the condition checks for the ending Fahrenheit value. 
         * Your table must look professional!
         */
        static void Main(string[] args)
        {
            // Fahrenheit = 9/5 * Celsius + 32
            // Celsius = (Fahrenheit - 32) * 5/9
            Console.Write("Enter the starting Fahrenheit value: ");
            double s_fa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the ending Fahrenheit value: ");
            double e_fa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the increment value: ");
            double increment = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" Fahrenheit\tCelsius");
            Console.WriteLine("----------------------");
            while(s_fa < e_fa)
            {
                double celsius = (s_fa - 32) * 5 / 9;
                Console.WriteLine($" {s_fa}\t\t{celsius:f2}");
                s_fa += increment;
            }
      
        }
    }
}
