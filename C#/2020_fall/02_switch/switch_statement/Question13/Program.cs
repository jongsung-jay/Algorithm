using System;

namespace Question13
{
    class Program
    {
        /*
         * for a college’s admissions office. The user enters a numeric high school grade point average (for example, 3 2) 
         * and an admission test score. Print the message “Accept” 
         * if the student meets either of the following requirements 
            A grade point average of 3.0 or higher and an admission test score of at least 60 
            A grade point average of less than 3.0 and an admission test score of at least 80 
            If the student does not meet either of the qualification criteria, print ‘Reject” 

         */
        static void Main(string[] args)
        {
            string gradeinfo;
            Console.Write("Enter a numeric grade point average: ");
            double grade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an admission test score: ");
            double score = Convert.ToDouble(Console.ReadLine());

            if (grade >= 3.0 && score >= 60)
            {
                gradeinfo = "Accept";
            }
            else if (grade <= 3.0 && score >= 80)
            {
                gradeinfo = "Accept";
            }
            else
            {
                gradeinfo = "Reject";
            }

            switch (gradeinfo)
            {
                case "Accept":
                    Console.WriteLine("Accept");
                    break;
                case "Reject":
                    Console.WriteLine("Reject");
                    break;
                default:
                    break;

            }
        }
    }
}
