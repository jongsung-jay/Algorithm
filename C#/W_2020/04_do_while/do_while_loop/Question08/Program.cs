using System;

namespace Question08
{
    class Program
    {
        /*
        To display the sum of all the multiples of 3 between 1000000 and 2000000. (Answer = 499, 999, 500, 000). 
        If you suspect that a value might be larger than 2 billion (as is the case here), 
        then the type of sum should be a long and not an int. 
        [Hint: like the C (currency) and the F (decimal) format specifiers, there is also a N specifier]
         */
        static void Main(string[] args)
        {
            int i = 1000000; 
            double sum = 0;
            do
            {
                if(i % 3 == 0)
                {
                    int n = i;
                    sum = sum + n;
                    i++;
                }
                i++;
            } while (i <= 2000000);
            Console.WriteLine($"{sum:n}");
        }
    }
}
