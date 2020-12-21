using System;

namespace Question08
{
    class Program
    {
        /*
         * Harmonised tax exists in Ontario, New Brunswick, New Foundland, Nova Scotia, and British Columbia. 
         * Use a suitable enum declaration and a switch statement to prompt the user for a province 
         * and display a message HST exist or HST does not exist. enum {ON, QC, NS, NB, MB, BC, PE, SK, AB, NL, YT, NT, NV}
         */
        enum code{ ON, QC, NS, NB, MB, BC, PE, SK, AB, NL, YT, NT, NV }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the province code: ");
            string code = Convert.ToString(Console.ReadLine().ToUpper());

            switch (code)
            {
                case "ON":
                case "NB":
                case "NL":
                case "NS":
                case "BC":
                    Console.WriteLine("HST exist");
                    break;
                default:
                    Console.WriteLine("HST does not exist");
                    break;
            }
        }
    }
}
