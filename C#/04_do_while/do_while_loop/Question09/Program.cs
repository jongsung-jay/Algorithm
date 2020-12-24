using System;

namespace Question09
{
    class Program
    {
        /*
         * A conversion table of Celsius to Fahrenheit temperature. 
         * The table must start with 100 Celsius and end at 0 Celsius with decrements of 10. (Fahrenheit = 9/5 * Celsius + 32). 
         * Your table must have a suitable header and the values in the table must be right-align like the output of question 11.
         */
        static void Main(string[] args)
        {
            int celsius = 100;
            double fahreheit;
            Console.WriteLine("Celsius\t\tFahrenheit");
            Console.WriteLine("---------------------------");
            do
            {
                fahreheit = (double)9 / (double)5 * celsius + 32;
                Console.WriteLine($" {celsius,3}\t\t {fahreheit,3:f2}");
                celsius--;
            } while (celsius >= 0);
        }
    }
}
