using System;

namespace ConsoleApp1
{
    class Program
    {
        // Question01
        static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu: ");
            Console.WriteLine("3) Calculation Sum: ");
            Console.WriteLine("4) Calculation Sum of Squares: ");
            Console.WriteLine("5) Calculation Sum of Cubes: ");
            Console.WriteLine("5) Calculation Average: ");
            Console.WriteLine("0) Exit");
            Console.WriteLine("");
            Console.Write("Enter the number that corresponds to your choice: ");
        }

        // Question 02
        static void Main(string[] args)
        {
            string choice;
            do
            {
                DisplayMenu();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "3":
                        Console.WriteLine($"sum : {CalculateSum(5)}");
                        Console.WriteLine("");
                        break;
                    case "4":
                        Console.Write("Enter the lotation number: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(CalculateSumOfSquares(input));
                        Console.WriteLine("");
                        break;
                    case "5":
                        Console.Write("Enter the lotation number: ");
                        int input2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(CalculateSumOfCubes(input2));
                        Console.WriteLine("");
                        break;
                    case "6":
                        Console.Write("Enter the lotation number: ");
                        double input3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(CalculateAverage(input3));
                        Console.WriteLine("");
                        break;
                    case "7":
                        DisplayEquation();
                        break;
                    case "0":
                        Console.WriteLine("Good Bye....");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("An Error message...");
                        break;
                }
            } while (choice != "0");
        }

        // Question 03
        static int CalculateSum(int inputs) 
        {
            int sum = 0;
            for(int i = 1; i <= inputs; i++)
            {
                Console.Write("Enter the number: ");
                int sum_number = Convert.ToInt32(Console.ReadLine());
                sum = sum + sum_number;
            }
            return sum;
        }

        // Question 04
        static int CalculateSumOfSquares(int input)
        {
            int sumSquares = 0;
            for(int i=1; i<= input; i++)
            {
                Console.Write("Enter the number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sumSquares = sumSquares + (number * number);
            }
            return sumSquares;
        }

        // Question 05
        static int CalculateSumOfCubes(int input2)
        {
            int sumCubes = 0;
            for(int i=1; i<=input2; i++)
            {
                Console.WriteLine("Enter the number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sumCubes = sumCubes + (number * number * number);
            }
            return sumCubes;
        }

        // Question 06
        static double CalculateAverage(double input3)
        {
            double sum = 0, average = 0;
            for(int i=1; i <= input3; i++)
            {
                Console.WriteLine("Enter the number: ");
                double number = Convert.ToDouble(Console.ReadLine());

                sum += number;
            }
            average = sum / input3;
            return average;
        }

        // Question 07
        static void DisplayEquation()
        {
            double x, y;
            Console.WriteLine(" x       5      3x      -2x^2     y");
            Console.WriteLine("---------------------------------------");
            for (x = 0.0; x <= 2.0; x += 0.25)
            {
                Console.WriteLine($"{x:f1}\t5.0\t{3 * x:f1}\t{(-2*x*x):f1}\t{5+(3*x)-(2*x*x):f1}");
            }
        }
    }
}
