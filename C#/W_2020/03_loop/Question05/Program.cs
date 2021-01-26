using System;

namespace Question05
{
    class Program
    {
        /*
         * Write a C# program to convert Celsius degrees to Fahrenheit. 
         * The program should request the starting Celsius value, the number of conversion to be made, and the increments between Celsius values. 
         * The display should have appropriate headings and list the Celsius value and the corresponding Fahrenheit value. 
         * Use the relationship: Fahrenheit = (9.1) / 5.0) * Celsius + 32.0.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a starting Celsius value: ");
            int s_celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a ending Celsius value: ");
            int e_celsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a increment value: ");
            int icr = Convert.ToInt32(Console.ReadLine());
            int i;
            double fahrenheit;
            Console.WriteLine("Celsius\t\tFahrenheit");
            Console.WriteLine("---------------------------");
            for (i = s_celsius; i <= e_celsius; i += icr)
            {
                fahrenheit = 9.1 / 5.0 * i + 32.0;
                Console.WriteLine("  {0}\t\t {1:f2}", i, fahrenheit);
            }
        }
    }
}
