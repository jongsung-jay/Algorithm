using System;

namespace Question07
{
    class Program
    {
        /*
         * Write a program to produce a table of numbers from 10 to 1, with their squares and cubes. 
         * Again, your table must look professional!
         */
        static void Main(string[] args)
        {
            int i = 10;
            int squares, cubes;
            Console.WriteLine(" number\tsquares\tcubes");
            Console.WriteLine("----------------------");
            while (i >= 1)
            {
                squares = i * i;
                cubes = squares * i;
                Console.WriteLine($" {i,2}\t{squares,3}\t{cubes,4}");
                i--;
            }
        }
    }
}
