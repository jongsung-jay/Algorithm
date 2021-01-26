using System;

namespace Question18
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd1 = new Random();
            int randomNo1 = rnd1.Next(1, 4);
            Random rnd2 = new Random();
            int randomNo2 = rnd2.Next(1, 4);
            Random rnd3 = new Random();
            int randomNo3 = rnd3.Next(1, 4);

            //input & Algorithm
            Console.WriteLine("Enter the frist no: ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second no: ");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third no: ");
            int no3 = Convert.ToInt32(Console.ReadLine());

            //algorithm
            // if Three matching in exact order
            if (no1 == randomNo1)
            {
                if (no2 == randomNo2)
                {
                    if (no3 == randomNo3)
                    {
                        Console.WriteLine($" your input no are: {no1}, {no2}, {no3}\ncomputer random no are:{randomNo1},{randomNo2};{randomNo3}\nyou win $10000.00");

                    }
                }
            }
            //if Three matching, not in order      
            else if (no1 == randomNo1 || no1 == randomNo2 || no1 == randomNo3)
            {
                if (no2 == randomNo1 || no2 == randomNo2 || no2 == randomNo3)
                {
                    if (no3 == randomNo1 || no3 == randomNo2 || no3 == randomNo3)
                    {
                        Console.WriteLine($" your input no are: {no1}, {no2}, {no3}\ncomputer random no are:{randomNo1},{randomNo2};{randomNo3}\nyou win $1000.00");
                    }
                }
            }

            //if Two matching              
            else if (no1 == randomNo1 && no2 == randomNo2)
            {
                if (no3 == randomNo3 && no1 == randomNo1)
                {
                    if (no1 == randomNo1 && no3 == randomNo3)
                    {
                        Console.WriteLine($" your input no are: {no1}, {no2}, {no3}\ncomputer random no are:{randomNo1},{randomNo2};{randomNo3}\nyou win $100.00");
                    }
                }
            }

            // if one matching             
            else if (no1 == randomNo1 || no1 == randomNo2 || no3 == randomNo3 || no2 == randomNo1 || no2 == randomNo2 || no2 == randomNo3 || no3 == randomNo1 || no3 == randomNo2 || no3 == randomNo3)
            {
                Console.WriteLine($" your input no are: {no1}, {no2}, {no3}\ncomputer random no are:{randomNo1},{randomNo2};{randomNo3}\nyou win $100.00");

            }
            //if no matching
            else
            {
                Console.WriteLine("No matches");
            }
            Console.ReadKey();
        }

    }
}
