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
            Console.WriteLine();
            Console.WriteLine("Letter\tDecimal\tOctal\tHex");
            Console.WriteLine("---------------------------------------");
            for (char c = Convert.ToChar(letter1); c <= Convert.ToChar(letter2); c++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", c, (int)c, Convert.ToString(c, 8), Convert.ToString(c, 16));
            }
        }
    }
}
