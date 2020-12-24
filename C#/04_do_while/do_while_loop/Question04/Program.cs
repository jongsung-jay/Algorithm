using System;

namespace Question04
{
    class Program
    {
        /*
         * To display the numbers 10 … 40 on separate lines with an asterisk before each multiple of 7. (asterisk multiples)
         */
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("*****");
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;         
            }
            while (i <= 40);           
        }
    }
}
