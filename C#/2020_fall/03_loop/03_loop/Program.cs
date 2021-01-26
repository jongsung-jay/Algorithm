using System;

namespace _03_loop
{
    class Program
    {
        /*
         * Write a program to print the numbers 2 to 10 in increments of two. 
         * The output of your program should be 2 4 6 8 10 
         */
        static void Main(string[] args)
        {
            int i;
            for (i = 2; i <= 10; i+=2) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
