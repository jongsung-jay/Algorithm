using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Tweet
    {
        // Fields
        private static int CURRENT_ID;

        //properties
        public string From { get;}
        public string To { get;}
        public string Body { get;}
        public string Tag { get;}
        public string Id { get;}
        
        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = CURRENT_ID.ToString();
            CURRENT_ID++;
        }
        public Tweet(string from, string to, string body, string tag, string id)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = id;
        }
        public override string ToString()
        {
            string body = Body;
            if (body.Length > 40) {
                body = body.Substring(0,40);
            }
            return $"ID: {Id} \n" + 
                   $"From: {From} \n" +
                   $"To: {To} \n" +
                   $"Body: {Body} \n" + 
                   $"Tag: {Tag}";
        }
        public static Tweet Parse(string line)
        {
            string[] tweetParam = line.Split(new char[]{'\t'});
            Tweet tweetLine = new Tweet(tweetParam[1], tweetParam[2], tweetParam[3], tweetParam[0]);
            return tweetLine;
        }
    }
}

