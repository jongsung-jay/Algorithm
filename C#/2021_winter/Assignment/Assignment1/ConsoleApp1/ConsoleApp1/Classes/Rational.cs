using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Classes
{
    class Rational
    {
        // Properties
        public int Denominator { get; private set; }
        public int Numerator { get; private set; }

        // Constructor
        public Rational(int numerator = 0, int denominator = 1)
        {
            this.Denominator = denominator;
            this.Numerator = numerator;
        }

        // Methods
        public override string ToString()
        {
            return String.Format($"{Numerator}/{Denominator}");
        }

        public void IncreaseBy(Rational other)
        {
            Numerator = Numerator * other.Denominator + other.Numerator * Denominator;
            Denominator = Denominator * other.Denominator;
        }

        public void DecreaseBy(Rational other)
        {
            Numerator = Numerator * other.Denominator - other.Numerator * Denominator;
            Denominator = Denominator * other.Denominator;
        }
    }
}
