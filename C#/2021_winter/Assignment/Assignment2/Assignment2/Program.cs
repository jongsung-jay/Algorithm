using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Below two line of code for testing
            //TweetManager.Initialize();
            //TweetManager.ShowAll();

            //Below lines in production
            TweetManager.ShowAll("taxes");
            TweetManager.ShowAll("Ford");
        }
    }
}
