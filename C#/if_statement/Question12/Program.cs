using System;
/*
 * Write a console-based program for a lawn-mowing service. 
 * The lawn-mowing season lasts 20 weeks. 
 * The weekly fee for mowing a lot less than 400 square feet is $25. 
 * The fee for a lot that is 400 square feet or more, but less than 600 square feet, is $35 per week. 
 * The fee for a lot that is 600 square feet or over is $50 per week. 
 * Prompt the user for the length and width of a lawn, and then display the weekly mowing fee, 
 * as well as the total fee for the 20-week season. 
 */
namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int season = 20;
            Console.WriteLine("Enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            // progressing
            int square = length * width;

            // output
            int total_fee;

            // algorithm
            if(square < 400)
            {
                total_fee = season * 25;
                Console.WriteLine($"weekly fee is $25, and total fee is {total_fee}");
            }
            else if(square >= 400 && square < 600)
            {
                total_fee = season * 35;
                Console.WriteLine($"weekly fee is $25, and total fee is {total_fee}");
            }
            else if (square >= 600)
            {
                total_fee = season * 50;
                Console.WriteLine($"weekly fee is $25, and total fee is {total_fee}");
            }
            Console.ReadKey();
        }
    }
}
