using System;

namespace method2
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPersonalInformation();
            DisplayAreaOfCircle(1);
            DisplayAreaOfCircle(10);
            double resultTax = CalculateTax(10);
            Console.WriteLine($"Result of tax: {resultTax:c2}");
            GetVolumeOfCube();
        }

        // Question01
        static void DisplayPersonalInformation()
        {
            string name = "Jongsung", program ="software engineering", favorite_course="web development";
            Console.WriteLine($"Name: {name}\nProgram: {program}\nFavorite course: {favorite_course}");
        }

        // Question02
        static void DisplayAreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Radius: {area:f2}");
        }

        // Question03
        static double CalculateTax(double price)
        {
            // tax = 14% of price
            double tax = 0.14;
            double TaxOfPrice = price * tax;
            return TaxOfPrice;
        }

        // Question04
        static double GetVolumeOfCube()
        {
            Console.Write("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double volume = length * width * height;
            Console.WriteLine($"volume: {volume:f2}");
            return volume;
        }
    }
}
