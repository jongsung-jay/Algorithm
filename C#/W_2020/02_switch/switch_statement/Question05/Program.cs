using System;

namespace Question05
{
    class Program
    {
        /*
         * Write a program that prompts the user for a day of the week. 
         * The program will display a message based on the following table:
            Choice	Message
            Sun	"Home"
            Mon	"Work"
            Tue	"Work"
            Wed	"Home"
            Thu	"Work"
            Fri	"Work"
            Sat	"Work"

         */
        static void Main(string[] args)
        {
            Console.Write("Enter the first three letter of the day: ");
            string day = Convert.ToString(Console.ReadLine().ToLower());

            switch(day)
            {
                case "sun":
                case "wed":
                    Console.WriteLine("Home");
                    break;
                default:
                    Console.WriteLine("Work");
                    break;
            }
        }
    }
}
