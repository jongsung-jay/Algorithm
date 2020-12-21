using System;

namespace Question06
{
    /*
     * Write a console-based program that prompts the user for an hourly pay rate and hours worked. 
     * Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax). 
     * Withholding tax is computed as a percentage of gross pay based on the following:
     */
    class Program
    {
        static void Main(string[] args)
        {
            double pay_rate, hours;
            double pay, tax, net;
            Console.Write("Enter a hourly pay rate: ");
            pay_rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a hours: ");
            hours = Convert.ToDouble(Console.ReadLine());

            pay = pay_rate * hours;

            if (pay <= 300)
            {
                tax = pay * 0.1;
                net = pay - tax;
                Console.WriteLine($"gross pay : {pay:c2}, withholding tax : {tax:c2}, net pay : {net:c2}");
            }
            else
            {
                tax = pay * 0.12;
                net = pay - tax;
                Console.WriteLine($"gross pay : {pay:c2}, withholding tax : {tax:c2}, net pay : {net:c2}");
            }
        }
    }
}
