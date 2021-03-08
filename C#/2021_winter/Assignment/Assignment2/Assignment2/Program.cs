using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Show All");
            Console.WriteLine("-----------------------------------------------------------");
            TweetManager.ShowAll();
            Console.WriteLine("Show with tag");
            Console.WriteLine("-----------------------------------------------------------");
            TweetManager.ShowAll("Raptors");
        }
    }
}
