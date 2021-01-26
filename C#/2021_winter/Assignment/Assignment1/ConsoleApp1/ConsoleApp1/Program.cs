using System;
using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(2, 1);
            Rational r3 = new Rational(numerator: 2);
            Rational r4 = new Rational();

            Console.WriteLine("Two rational numbers are {0} and {1}", r1, r2);
            r1.IncreaseBy(r2);
            Console.WriteLine("Addition of two above rational number is {0}", r1);
            Console.WriteLine();
            Console.WriteLine("Two rational numbers are {0} and {1}", r3, r4);
            r3.DecreaseBy(r4);
            Console.WriteLine("Substraction of two above rational number is {0}", r3);
        }
    }
}
