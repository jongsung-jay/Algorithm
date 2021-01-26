using System;
namespace switch_statement
{
    class Program
    {
        /*
         * Write a c# program that prompts the user for a single letter. 
         * If the letter is a then display Apple, 
         * if the letter is b or c then display Baby or Candy or anything else Sorry I don’t know that letter.
         */
        static void Main(string[] args)
        {
            Console.Write("Enter a single letter: ");
            char letter = Convert.ToChar(Console.ReadLine().ToLower());

            switch(letter)
            {
                case 'a':
                    Console.WriteLine("Apple");
                    break;
                case 'b':
                    Console.WriteLine("Baby");
                    break;
                case 'c':
                    Console.WriteLine("Candy");
                    break;
                default:
                    Console.WriteLine("I don't know that letter...");
                    break;
            }
            Console.ReadKey();
        }
    }
}
