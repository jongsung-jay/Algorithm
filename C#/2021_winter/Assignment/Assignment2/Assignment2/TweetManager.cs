using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment2
{
    static class TweetManager
    {
        // Fields
        private static List<Tweet> tweets;
        private static string filename = @"C:\Users\JONGSUNG\OneDrive\Desktop\C#\Assignment_02_TweetFile.txt";

        // Methods
        static TweetManager()
        {
            tweets = new List<Tweet>();
            try
            {
                using (TextReader reader = new StreamReader(filename))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        tweets.Add(Tweet.Parse(line));
                        line = reader.ReadLine();
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
 
        public static void Initialize(string line)
        {
            tweets.Add(Tweet.Parse("Raptors	Drake	Obama	Go Raptors! Go!"));
            tweets.Add(Tweet.Parse("Raptors	Tory	Obama	Toronto joins cities around the world to celebrate International Day Against Homophobia & Transphobia"));
            tweets.Add(Tweet.Parse("Taxes	Drake	Bieber	Go Raptors! Go!"));
            tweets.Add(Tweet.Parse("Raptors	Tory	Drake	Yes Toronto will get them!"));
            tweets.Add(Tweet.Parse("Leaf	Drake	Bieber	Go Leafs! Go!"));
        }


        public static void ShowAll()
        {
            foreach (Tweet tweet in tweets)
            {
                Console.WriteLine(tweet + "\n");
            }
        }

        public static void ShowAll(string tag)
        {
            foreach (Tweet tweet in tweets)
            {
                if (tweet.Tag.ToLower() == tag.ToLower())
                {
                    Console.WriteLine(tweet + "\n");
                }
            }
        }
    }
}
