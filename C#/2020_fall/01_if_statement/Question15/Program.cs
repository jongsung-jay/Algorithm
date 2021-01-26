using System;
/*
 * You can create a random number that is at least min but less than max using the following statements:
    Random ranNumberGenerator = new Random();
    int randomNumber;
    randomNumber = ranNumberGenerator.Next(min, max);
   Write a console-based program that generates a random number between 1 and 10. (In other words, min is 1 and max is 11.) 
   Ask a user to guess the random number, then display the random number and a message indicating 
   whether the user’s guess was too high, too low, or correct.

 */
namespace Question15
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 11);

            Console.WriteLine("Enter the random number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number < randomNumber)
            {
                Console.WriteLine($"your number : {number}, random number : {randomNumber}");
                Console.WriteLine("Your guess is low");
            }
            else if (number == randomNumber)
            {
                Console.WriteLine($"your number : {number}, random number : {randomNumber}");
                Console.WriteLine("Your guess is correct");
            }
            else if (number > randomNumber)
            {
                Console.WriteLine($"your number : {number}, random number : {randomNumber}");
                Console.WriteLine("Your guess is high");
            }
        }
    }
}
