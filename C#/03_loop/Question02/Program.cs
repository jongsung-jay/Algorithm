using System;

namespace Question02
{
    class Program
    {
        /*
         * Write a program to produce a table that starts at a Celsius value of -10 
         * and ends with a Celsius value of 60, in increments of ten degrees. 
         */
        static void Main(string[] args)
        {
            int i;
            for(i=-10; i <= 60; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
