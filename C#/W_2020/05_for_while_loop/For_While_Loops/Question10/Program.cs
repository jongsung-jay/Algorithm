using System;

namespace Question10
{
    class Program
    {
        /*
         * Write a C program that continuously requests a grade. 
        If the grade is less than 0 or greater than 100, your program should print an appropriate message informing the user 
        that an invalid grade has been entered, else the grade should be added to a total. 
        If the grade is 999, the program should exit the loop and display the sum, number of valid grades 
        and the average of the valid grades entered. (You must NOT display an invalid message)
        P.S. The value 999 is use to terminate the cycle and should not be used in any of the calculation.
        You must not display an “Invalid grade”

         */
        static void Main(string[] args)
        {
            int total = 0;
            int i=1;
            double average = 0;
            while (true)
            {
                Console.Write("Enter the grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade < 0 || grade > 100 && grade !=999)
                {
                    Console.WriteLine("Error..Enter the grade again: ");
                    
                }
                else if (grade == 999)
                {
                    Console.WriteLine("Exit program...");
                    break;
                }
                else
                {
                    total += grade;
                    average = total / i;
                    i++;
                }
            }
            Console.WriteLine($"number of grade : {i-1}, total : {total}, average : {average}");
            
        }
    }
}
