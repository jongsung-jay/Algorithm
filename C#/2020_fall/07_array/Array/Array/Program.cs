using System;

namespace Array
{
    class Program
    {
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };

        static void Main(string[] args)
        {
            printObama();
            printPoem();
            printprimes();
            printDoublesprimes();
        }

        /* Question01
         * Write a method that prints the string array obama. Each element must be on a separate line.
         * From your main, call this method. [Your method will not take any parameters and it does not return a value.]
         */

        static void printObama()
        {
            string[] obama = { "Barack", "Hussein", "Obama" };
            for (int i = 0; i < obama.Length; i++)
            {
                Console.WriteLine(obama[i]);
            }
        }

        /* Question02
         * Write a method that prints the string array poem in reverse order. All the items must be in the same line. 
         * Your method will not take any parameters and it does not return a value.
         * From your main, call this method. 
         */
        static void printPoem()
        {
            string[] poem = { "Mary", "had", "a", "little", "lamb" };
            int reverse = poem.Length;
            for(int i= reverse-1; i>= 0; i--)
            {
                Console.Write($"{poem[i]}, ");
            }
        }

        /* Question03
         * Write a method that sums all the items of the array primes, and then display this sum.
         * From your main, call this method. [Your method will not take any parameters and it does not return a value.]
         */
        static void printprimes()
        {
            // int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
            int sum = 0;
            for(int i=0;i < primes.Length; i++)
            {
                sum += primes[i];
            }
            Console.WriteLine("");
            Console.WriteLine($"SumOfPrimes: {sum}");
        }

        /* Question04
         * Write a method that doubles all the items of the int array primes. This method does not display anything.
         * From your main, call the previous method, this method and then the previous method again. 
         * Because the previous method was called twice, you will have two printouts, one with the original value and the second one with the doubled values. 
         * [Your method will not take any parameters and it does not return a value.] 
         */
        static void printDoublesprimes()
        {
            for (int i = 0; i < primes.Length; i++)
            {
                Console.Write($"{primes[i]}, ");
            }
            Console.WriteLine("");
            for (int i=0; i < primes.Length; i++)
            {
                Console.Write($"{primes[i] * primes[i]}, ");
            }
        }

        /* Question05
         * A) Write a method that will subtract 32 from each item of the char array vowels. 
         *    The result of any arithmetic operation is a number, so you will have to cast your result to a char in order to assign the resulting value to the char array 
         * B) Write a second method that will display all the items of the char array vowels on a single line 
         * C) From your main, call the second method, then the first and then the second again
         * Subtracting or adding 32 is a common technique for converting from lower case alphabet to upper case alphabet and vice-versa
         */
        static void printVowles()
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        }


    }

}
