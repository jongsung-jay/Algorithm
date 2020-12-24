using System;

namespace Question10
{
    class Program
    {
        /*
        Write a C program that continuously requests a grade to be entered. 
        If the grade is less than 0 or greater than 100, your program should print an appropriate message informing the user 
        that an invalid grade has been entered, else the grade should be added to a total. 
        When a grade of 999 is entered the program should exit the repetition loop and compute 
        and display the average of the valid grades entered.

         */
        static void Main(string[] args)
        {
            int grade;
            int total = 0;
            while(true)
            {
                Console.Write("Enter a grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                if(grade == 999)
                {
                    Console.WriteLine("Exit program..");
                    break;
                }
                else if(grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid value...");
                    Console.Write("Enter a grade again: ");
                    grade = Convert.ToInt32(Console.ReadLine());
                    if (grade == 999)
                    {
                        Console.WriteLine("Exit program..");
                        break;
                    }
                }
                else
                {
                    total = total + grade;
                }
            }
            Console.WriteLine(total);
        }
    }
}
