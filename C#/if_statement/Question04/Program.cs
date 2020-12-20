using System;

namespace Question04
{
    /*
     * Write a console-based program that accepts a user’s message 
     * and determines whether it is short enough for a social networking service that 
     * does not accept messages of more than 140 characters. 
     * [Hint: if the user’s input is assigned to the variable message then message.Length with give the number of characters 
     * in the input]
     */
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            Console.Write("Enter a messages but not more than 140 characters:  ");
            message = Convert.ToString(Console.ReadLine());
            //int length = message.Length;
            if (message.Length > 140)
            {
                Console.WriteLine("Sorry, your message is not accepted, because it is too long");
            }
            else
            {
                Console.WriteLine($"Your message accepted");
            }
        }
    }
}
