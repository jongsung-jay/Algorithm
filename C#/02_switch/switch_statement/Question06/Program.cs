using System;

namespace Question06
{
    class Program
    {
        /*
         * Write a program for a furniture company. Ask the user to choose Pine, Oak or Mahogany. 
         * Show the price of a table manufactured with the chosen wood Pine tables cost $100, Oak tables cost $225, 
         * and Mahogany tables cost $310. You must use named constants and switch. 
         * Also you must be able to accept any variation on the case. E.g. Pine, pine PINE, pinE, Pine … should give $100.
         */
        static void Main(string[] args)
        {
            int cost_pine = 100;
            int cost_oak = 225;
            int cost_mahogany = 310;
            Console.Write("Enter the type of wood for your table: ");
            string manufacture = Convert.ToString(Console.ReadLine().ToLower());

            switch (manufacture)
            {
                case "pine":
                    Console.WriteLine($"The table cost is {cost_pine:c}");
                    break;
                case "oak":
                    Console.WriteLine($"The table cost is {cost_oak:c}");
                    break;
                case "mahogany":
                    Console.WriteLine($"The table cost is {cost_mahogany:c}");
                    break;
                default:
                    Console.WriteLine("Error: You Enter a invalid wood type");
                    break;
            }
        }
    }
}
