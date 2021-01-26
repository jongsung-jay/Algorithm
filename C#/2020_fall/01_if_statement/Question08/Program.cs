using System;
/*
 * Write a program that allows the user to enter two integers and a character 
 * If the character is A, add the two integers 
 * If it is S, subtract the second integer from the first 
 * if it is M, multiply the integers 
 * Display the results of the arithmetic
 */
namespace Question08
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.Write("Enter a first integer: ");
            int first_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second integer: ");
            int second_int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character: ");
            string letter = Convert.ToString(Console.ReadLine());

            // output
            int result = 0;

            //algorithm
            if (letter == "A")
            {
                result = first_int + second_int;
            }
            else if(letter == "S")
            {
                result = first_int - second_int;
            }
            else if(letter == "M")
            {
                result = first_int * second_int;
            }
            else
            {
                Console.WriteLine("Error...");
            }
            Console.WriteLine($"The input letter is {letter}, and result is {result}");
            Console.ReadKey();
        }
    }
}
