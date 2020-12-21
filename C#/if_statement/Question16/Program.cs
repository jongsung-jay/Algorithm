using System;
/*
 * In the game Rock Paper Scissors, two players simultaneously choose one of three options: rock, paper, or scissors. 
 * If both players choose the same option, then the result is a tie. 
 * However, if they choose differently, the winner is determined as follows:
    Rock beats scissors, because a rock can break a pair of scissors.
    Scissors beats paper, because scissors can cut paper.
    Paper beats rock, because a piece of paper can cover a rock.
 */
namespace Question16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the option(Rock / Paper / Scissors): ");
            string option1 = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the option(Rock / Paper / Scissors): ");
            string option2 = Convert.ToString(Console.ReadLine());

            if (option1 == option2)
            {
                Console.WriteLine("Tie...");
            }
            else
            {
                if(option1 == "rock" && option2 =="scissors" || option1 == "scissors" && option2 == "paper" || option1 == "paper" && option2 == "rock")
                {
                    Console.WriteLine("player1 win");
                }
                else
                {
                    Console.WriteLine("plater2 win");
                }
            }
        }
    }
}
