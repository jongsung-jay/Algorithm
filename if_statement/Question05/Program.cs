using System;

namespace Question05
{
    /*
     * Write an application that asks a user to enter an IQ score. 
     * If the score is a number less than 0 or greater than 200, issue an error message; 
     * otherwise, issue an “above average”, “average”, or “below average” message for scores over, at, or under 100, respectively
     */
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("Enter an IQ score: ");
            score = Convert.ToInt32(Console.ReadLine());

            if(score < 0 || score > 200)
            {
                Console.WriteLine("Error");
            }
            else if(score < 100)
            {
                Console.WriteLine("Below average");
            }
            else if(score == 100)
            {
                Console.WriteLine("Average");
            }
            else
            {
                Console.WriteLine("Above average");
            }
        }
    }
}
