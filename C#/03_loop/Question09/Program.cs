using System;

namespace Question09
{
    class Program
    {
        /*
         * Write a program to produce a table of numbers from 10 to 1, with their squares and cubes.
         */
        static void Main(string[] args)
        {
            int i, squares, cubes;
            Console.WriteLine(" num\t\tsquares\t\tcubes");
            for (i = 10; i >= 1; i -= 1)
            {
                squares = i * i;
                cubes = i * i * i;
                Console.WriteLine($" {i,2}\t\t{squares,4}\t\t{cubes,4}");
            }
        }
    }
}
