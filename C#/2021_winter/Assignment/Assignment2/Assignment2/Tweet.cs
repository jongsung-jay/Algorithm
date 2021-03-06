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
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = CURRENT_ID.ToString();
            CURRENT_ID++;
        }
        public Tweet(string from, string to, string body, string tag, string id)
        {
            this.From = from;
            this.To = to;
            this.Body = body;
            this.Tag = tag;
            this.Id = id;
        }
        public override string ToString()
        {
            string body = this.Body;
            if (body.Length > 40) {
                body = body.Substring(0,40);
            }
            return $"ID: {this.Id} \n" + 
                   $"From: {this.From} \n" +
                   $"To: {this.To} \n" +
                   $"Body: {this.Body} \n" + 
                   $"Tag: {this.Tag}";
        }
        public static Tweet Parse(string line)
        {
            string[] tweetParam = line.Split(new char[]{'\t'});
            Tweet tweetLine = new Tweet(tweetParam[1], tweetParam[2], tweetParam[3], tweetParam[4], tweetParam[0]);
            return tweetLine;
        }
    }
}

