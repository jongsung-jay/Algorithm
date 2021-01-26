using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Rational
    {
        // Fields
        private int numerator = 100; // This is a default value.
                                     // 100 goes aways if this.numerator is reassigne
        private int denominator;
        // Properties
        public int Numerator {
            get {
                return this.numerator;
            } // 이렇게 하면 Rational 메서드를 선언할 필요가 없음
            set {
                this.numerator = value;
            } 
        }

        public int Denominator {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value != 0) // Validation
                    this.denominator = value; 
            }
        }

        // Methods
        public Rational()
        {

        }
       /* public Rational(int numerator = 0, int denominator = 1)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }*/

        public override string ToString()
        {
            return $"Numerator: {this.Numerator}, Denominator: {this.Denominator}";
        }

        public void IncreaseBy(Rational rational)
        {
            // Implementation goes here
            this.Denominator = 5;
        }

        public void DecreaseBy(Rational rational)
        {
            // Implementation goes here
        }
    }
}
