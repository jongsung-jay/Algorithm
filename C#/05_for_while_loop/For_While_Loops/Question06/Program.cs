using System;

namespace Question06
{
    class Program
    {
        /*
         * Write a program to produce a table of the numbers 0 through 20 in increments of 2, with their squares and cubes. 
         * Your table must look professional!
         */
        static void Main(string[] args)
        {
            int num, squares, cubes;
            Console.WriteLine(" number\tsquares\tcubes");
            Console.WriteLine("----------------------");
            for (num = 0; num <= 20; num += 2)
            {
                squares = num * num;
                cubes = squares * num;
                Console.WriteLine($" {num,2}\t{squares,3}\t{cubes,4}");
            }
        }
    }
}
