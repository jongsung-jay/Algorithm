using System;

namespace Question11
{
    class Program
    {
        /*
         * Print the decimal, octal, and hexadecimal values of all characters between the start and stop characters entered by a user. 
         * For example, if the user enters an a and a z, the program should print all the characters between a and z 
         * and their respective numerical values. 
         * Make sure that the second character entered by the user occurs later in the alphabet than the first character. 
         * If it does not, write a loop that repeatedly asks the user for a valid second character until one is entered.
         */
        static void Main(string[] args)
        {
            char letter1, letter2;
            Console.Write("Enter the start character: ");
            letter1 = Convert.ToChar(Console.ReadLine());
            do
            {
                Console.Write("Enter the end character: ");
                letter2 = Convert.ToChar(Console.ReadLine());
            } while (Convert.ToInt32(letter1) > Convert.ToInt32(letter2));

            


        }
    }
}
