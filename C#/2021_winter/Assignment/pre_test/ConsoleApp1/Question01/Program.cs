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

/*
In your Program class, create a new method called GetInfo. This method receives one parameter: A string that is expected to contain a sentence. 

It returns a string that contains a metadata report on the specified string. 
The report should include: 
1: the total number of characters (Hint: spaces are characters) 
2: the total number of words
3: the longest word in that string. 
Each one of these should appear in an individual line in the report.

Once you are done, write the test harness in the Main method of your Program class, ensuring your code is fully functional as per requirements. 
In other words, define two or three random sentences in your Main method, and display a sentence report in the Console for each one of them.
You can choose your sentences freely.
For full marks, ensure your method handles exceptions properly, and in case of errors, display clean and meaninful messages to the user (Hint: Implement try-catch blocks).
 */