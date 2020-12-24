using System;

namespace Question08
{
    class Program
    {
        /*
         * Write a program to produce a table of the numbers 0 through 20 in increments of 2, with their squares and cubes
         */
        static void Main(string[] args)
        {
            int i, squares, cubes;
            Console.WriteLine("number\t\tsquares\t\tcubes");
            Console.WriteLine("---------------------------------------");
            for(i=0; i <= 20; i += 2)
            {
                squares = i * i;
                cubes = i * i * i;
                Console.WriteLine($" {i,4}\t\t{squares,4}\t\t{cubes,4}");
            }
        }
    }
}
