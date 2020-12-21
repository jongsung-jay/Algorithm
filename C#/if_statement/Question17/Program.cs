using System;
/*
 * Create a console-based game in which the computer randomly chooses rock, paper, or scissors. 
 * Let the user enter a character, ‘r’, ‘p’, or ‘s’, each representing one of the three choices.
 * Then, determine the winner.
 */
namespace Question17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 3);
            string computer_choice;
            if (randomNumber == '1')
            {
                computer_choice = "r";
            }
            else if (randomNumber == '2')
            {
                computer_choice = "p";
            }
            else
            {
                computer_choice = "s";
            }


            Console.Write("Enter the option(Rock(R) / Paper(P) / Scissors(S)): ");
            string option1 = Console.ReadLine().ToLower();
            
            if (option1 == computer_choice)
            {
                Console.WriteLine("Tie...");
            }
            else
            {
                if (option1 == "r" && computer_choice == "s" || option1 == "s" && computer_choice == "p" || option1 == "p" && computer_choice == "r")
                {
                    Console.WriteLine("player1 win");
                }
                else
                {
                    Console.WriteLine("computer win");
                }
            }
        }
    }
}
