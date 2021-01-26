using System;

namespace do_while_loop
{
    class Program
    {
        /*
         * To display five asterisks on a single line. 
         * Each asterisk must be separated by a space. You must use a do-while loop to solve this program
         */
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.Write("* ");
                i++;
            }
            while(i < 5) ;
        }
    }
}
