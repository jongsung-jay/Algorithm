using System;

namespace Question09
{
    class Program
    {
        /*
         * Write a program to calculate the roots of a quadratic equation. 
         * The flowchart below illustrates a possible solution
         */
        static void Main(string[] args)
        {
            int a, b, c;
            double p, d, q;
            Console.Write("Input the value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of c : ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("invalid input for a");
            }
            else
            {
                p = -b / (2 * a);
                d = (b * b) - (4 * a * c);
                if (d >= 0)
                {
                    q = Math.Sqrt(d) / (2 * a);
                    Console.WriteLine($"p + q = {p + q} and p - q = {p - q}");
                }
                else
                {
                    q = Math.Sqrt(-d) / 2 * a;
                    Console.WriteLine($"p + q = {p + q} and p - qi = {p - q}");
                }

            }
        }
    }
}
