using System;

namespace Question14
{
    class Program
    {
        /*
         * Write a program that prompts the user for an hourly pay rate and hours worked. 
         * Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay minus withholding tax) 
         * Withholding tax is computed as a percentage of gross pay based on the following
            Gross Pay                     Withholding Percentage 
            Up to and including 300.00    10% 
            300.01 and up                 12% 
         */
        static void Main(string[] args)
        {

            Console.Write("Enter an hourly pay rate: ");
            double hourly_pay_rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter hours worked: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            double withholdingTax;
            double withholdingPercentage;
            double grossPay = hourly_pay_rate * hours;
            
            if(grossPay <= 300)
            {
                withholdingPercentage = 0.1;
            }
            else
            {
                withholdingPercentage = 0.12;
            }

            switch (withholdingPercentage)
            {
                case 0.1:
                    withholdingTax = grossPay * withholdingPercentage;
                    double netpay = grossPay - withholdingTax;
                    Console.WriteLine($"grass pay : {grossPay}, withholdingTax : {withholdingTax}, netpay : {netpay}");
                    break;
                case 0.12:
                    withholdingTax = grossPay * withholdingPercentage;
                    netpay = grossPay - withholdingTax;
                    Console.WriteLine($"grass pay : {grossPay}, withholdingTax : {withholdingTax}, netpay : {netpay}");
                    break;
                default:
                    Console.WriteLine("Error...");
                    break;
            }               
        }
    }
}
