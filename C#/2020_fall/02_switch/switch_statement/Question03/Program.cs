using System;

namespace Question03
{
    class Program
    {
        /*
         * Write a program that allows the user to enter two integers and a character 
         * If the character is A, add the two integers 
         * If it is S, subtract the second integer from the first 
         * else multiply the integers Display the results of the arithmetic
         */
        static void Main(string[] args)
        {
            Console.Write("Enter a first integer: ");
            int first_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer: ");
            int second_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character: ");
            char character = Convert.ToChar(Console.ReadLine().ToLower());

            switch (character)
            {
                case 'a':
                    Console.WriteLine($"Add : {first_int + second_int}");
                    break;
                case 's':
                    Console.WriteLine($"subtract : {first_int - second_int}");
                    break;
                default:
                    Console.WriteLine($"multiply : {first_int * second_int}");
                    break;
            }
            Console.ReadKey();
        }
    }
}
