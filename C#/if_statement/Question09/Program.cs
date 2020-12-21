using System;
/*
 * Write a console-based application that asks a user to enter an IQ score. 
 * If the score is a number less than 0 or greater than 200, issue an error message; 
 * otherwise, issue an “above average”, “average”, or “below average” message for scores over, at, or under 100, respectively.
 */
namespace Question09
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("Enter an IQ score: ");
            score = Convert.ToInt32(Console.ReadLine());

            if(score < 0 || score > 200)
            {
                Console.WriteLine("error...");
            }
            else
            {
                if(score < 100)
                {
                    Console.WriteLine("below average");
                }
                else if(score == 100)
                {
                    Console.WriteLine("average");
                }
                else
                {
                    Console.WriteLine("above average");
                }
            }
        }
    }
}
