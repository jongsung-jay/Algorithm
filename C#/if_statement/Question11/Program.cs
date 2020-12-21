using System;
/*
 * Write a console-based program for a college’s admissions office. 
 * The user enters a numeric high school grade point average (for example, 3.2) and an admission test score. 
 * Display the message “Accept” if the student meets either of the following requirements:
   A grade point average of 3.0 or higher and an admission test score of at least 60
   A grade point average of less than 3.0 and an admission test score of at least 80
   If the student does not meet either of the qualification criteria, display “Reject”. 

 */
namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.Write("Enter a grade point average: ");
            double point_ave = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an admission test socre: ");
            double test_score = Convert.ToDouble(Console.ReadLine());

            // output

            // algorithm
            if(point_ave >= 3.0)
            {
                if (test_score >= 60)
                {
                    Console.WriteLine("Accept");
                }
                else
                {
                    Console.WriteLine("Reject");
                }
            }
            else
            {
                if (test_score >= 80)
                {
                    Console.WriteLine("Accept");
                }
                else
                {
                    Console.WriteLine("Reject");
                }
            }
            /*
             * Console.WriteLine("Enter your high scholl grade point average: ");
               double grade = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("Enter your admission test score: ");
               double testScore = Convert.ToDouble(Console.ReadLine());
               //Algorithm
               if (grade>=3.0 && testScore>=60)
                {
                    Console.WriteLine("Accept");
                }
                else if (grade < 3.0 && testScore >= 80)
                {
                    Console.WriteLine("Accept");
                }
                else
                    Console.WriteLine("Reject");
                Console.ReadKey();
             */
        }
    }
}
