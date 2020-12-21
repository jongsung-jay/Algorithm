using System;

namespace Question04
{
    class Program
    {
        /*
         * Write a program that prompts the user for the number of courses and residency status (domestic or international) 
         * and calculates tuition cost. Cost is calculated based on the table below.
            Domestic	$325 per course
            International	$1375 per course
           You decide how you want the user to enter her/his residency status and prompt accordingly, 
           also you should use named constants for the cost per course
         */
        static void Main(string[] args)
        {
            Console.Write("Enter the number of courses: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a residency status(Domestic/International): ");
            string status = Convert.ToString(Console.ReadLine().ToLower());

            int fee_domestic = 325;
            int fee_international = 1375;

            switch (status)
            {
                case "domestic":
                    Console.WriteLine($"The cost per course : {number * fee_domestic:c}");
                    break;
                case "international":
                    Console.WriteLine($"The cost per course : {number * fee_international:c}");
                    break;
                default:
                    Console.WriteLine("Enter the wrong information");
                    break;
            }
            Console.ReadKey();
        }
    }
}
