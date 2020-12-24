using System;

namespace Question02
{
    class Program
    {
        /*
         * To display the numbers 1 … 5 on separate lines
         */
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i + 1);
                i++;
            } while (i < 5);
        }
    }
}
