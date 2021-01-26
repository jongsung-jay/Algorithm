using System;

namespace Question03
{
    class Program
    {
        /*
         * To display the numbers 1 … 20 on separate lines with an asterisk after each multiple of 5. (multiples asterisk) 
         */
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                
                Console.WriteLine($"{i,2}");
                if (i % 5 == 0)
                {
                    Console.WriteLine("*****");
                }
                i++;
            } while (i <= 20);           
        }
    }
}
