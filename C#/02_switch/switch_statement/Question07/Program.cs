using System;

namespace Question07
{
    class Program
    {
        /*
         * Saturdays and Wednesdays are Narendra’s days off. Write a program to prompt the user for the day of the week. 
         * The program will display “Home day” or “Work day” depending on the input
         */
        static void Main(string[] args)
        {
            Console.Write("Enter the day of the week: ");
            string day = Convert.ToString(Console.ReadLine().ToLower());

            switch (day)
            {
                case "saturday":
                case "wendnesday":
                    Console.WriteLine("Home day");
                    break;
                default:
                    Console.WriteLine("Work day");
                    break;
            }
        }
    }
}
