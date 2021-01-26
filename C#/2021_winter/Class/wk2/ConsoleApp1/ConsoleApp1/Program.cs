using System;
using System.Collections;
using System.Collections.Generic;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rational numberA = new Rational();
            /* Rational numberB = new Rational(1,2);
             Rational numberC = new Rational(4,5);
             Rational numberD = new Rational(denominator:12, numerator:1);
            */
            // numberA.IncreaseBy(numberB);
            // -> 0 + 1/2 = 1/2

            // numberC.DecreaseBy(numberD);
            // -> something.

            // Console.WriteLine(numberA.Numerator);

            /*
            Rational[] rationals = new Rational[5];

            rationals[0] = new Rational();
            rationals[0].Numerator = 100;*/

            Rational rational = new Rational();
            
            //generic
            List<Rational> rationals = new List<Rational>();
            rationals.Add(rational);
            rationals.Add(rational);
            rationals.Add(rational);

            //rationals.Count(); // length
            //List<string> strings = new List<string>();
            ArrayList arrayList = new ArrayList();
            arrayList.Add(rational);
            arrayList.Add(123);
        }
    }
}
