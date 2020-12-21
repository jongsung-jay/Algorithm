using System;
/*
 * To the Lawn application you created in the above question, 
 * add a prompt that asks the user whether the customer wants to pay (1) once, (2) twice, or (3) 20 times per season. 
 * If the user enters 1 for once, the fee for the season is simply the seasonal total. 
 * If the customer requests two payments, each payment is half the seasonal fee plus a $5 service charge. 
 * If the user requests 20 separate payments, add a $3 service charge per week. 
 * Display the number of payments the customer must make, each payment amount, and the total for the season.
 */
namespace Question13
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
            if (square < 400)
            {
                total_fee = season * 25;
                Console.WriteLine($"weekly fee is $25, and total fee is {total_fee}");
                Console.Write("Enter pay option, whether pay once(1), twice(2) or 20 times per season(3): ");
                int option = Convert.ToInt32(Console.ReadLine());
                if(option == 1)
                {
                    int TotalSeasonFee = total_fee;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {TotalSeasonFee}");
                }
                else if(option == 2)
                {
                    int HalfSeasonFee = (total_fee / 2) + 5;
                    int TotalSeasonFee = HalfSeasonFee * 2;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {HalfSeasonFee}");
                }
                else if(option == 3)
                {
                    int weekly_fee = 25 + 3;
                    int TotalSeasonFee = weekly_fee * 20;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {weekly_fee}");
                }
            }
            else if (square >= 400 && square < 600)
            {
                total_fee = season * 35;
                Console.WriteLine($"weekly fee is $25, and total fee is {total_fee}");
                Console.Write("Enter pay option, whether pay once(1), twice(2) or 20 times per season(3): ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    int TotalSeasonFee = total_fee;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {TotalSeasonFee}");
                }
                else if (option == 2)
                {
                    int HalfSeasonFee = (total_fee / 2) + 5;
                    int TotalSeasonFee = HalfSeasonFee * 2;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {HalfSeasonFee}");
                }
                else if (option == 3)
                {
                    int weekly_fee = 35 + 3;
                    int TotalSeasonFee = weekly_fee * 20;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {weekly_fee}");
                }
            }
            else if (square >= 600)
            {
                total_fee = season * 50;
                Console.WriteLine($"weekly fee is $25, and total fee is {total_fee}");
                Console.Write("Enter pay option, whether pay once(1), twice(2) or 20 times per season(3): ");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    int TotalSeasonFee = total_fee;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {TotalSeasonFee}");
                }
                else if (option == 2)
                {
                    int HalfSeasonFee = (total_fee / 2) + 5;
                    int TotalSeasonFee = HalfSeasonFee * 2;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {HalfSeasonFee}");
                }
                else if (option == 3)
                {
                    int weekly_fee = 50 + 3;
                    int TotalSeasonFee = weekly_fee * 20;
                    Console.WriteLine($"option : {option}, total season fee : {TotalSeasonFee}, each fee : {weekly_fee}");
                }
            }
            Console.ReadKey();
        }
    }
}
