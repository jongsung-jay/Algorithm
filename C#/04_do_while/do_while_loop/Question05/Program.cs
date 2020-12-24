using System;

namespace Question05
{
    class Program
    {
        /*
         * To display numbers 20 … 60 on separate lines skipping the multiple of 3. 
         * i.e. You must print a blank line for each multiple.
         */
        static void Main(string[] args)
        {
            int i = 20;
            do
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            } while (i <= 60);
        }
    }
}
