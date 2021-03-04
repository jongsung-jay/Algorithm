using System;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sentence = "With great power comes great responsibility";
                string report = GetInfo(sentence);
                Console.WriteLine(report);

                string newSentence = null;
                Console.WriteLine(GetInfo(newSentence));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static string GetInfo(string sentence) {
            if (string.IsNullOrWhiteSpace(sentence))
                throw new Exception("Error: Sentence was empty");

            string report = "Sentence: " + sentence + "\n";
            report += "Number of characters: " + sentence.Length + "\n";
            report += "Number of word: " + sentence.Split(' ').Length + "\n";

            int max = 0;
            string longest = null;
            foreach (string word in sentence.Split(' ')) {
                if (word.Length > max) {
                    max = word.Length;
                    longest = word;
                }
            }
            report += "Longest word: " + longest + "\n";
            /*if (!string.IsNullOrWhiteSpace(longest))
                report += "Longest word: " + longest + "\n";
            else
                report += "Longest word: Argument string is empty" + "\n";*/

            return report;
        }


    }
}
