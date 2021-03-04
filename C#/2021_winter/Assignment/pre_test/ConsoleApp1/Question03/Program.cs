using System;
using System.IO;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = $"Gibson \n" +
                          $"Fender \n" +
                          $"PRS \n" +
                          $"Jackson \n" +
                          $"Charvel \n";

            // Writing to file
            TextService.SaveText(text, @"C:\Users\JONGSUNG\OneDrive\Desktop\C#\test\Guitars.txt");
            // Reading to file
            string content = TextService.LoadText(@"C:\Users\JONGSUNG\OneDrive\Desktop\C#\test\Guitars.txt");

            Console.WriteLine(content);
        }
    }

    public static class TextService {
        public static void SaveText(string sentence, string filename) {
            if (string.IsNullOrWhiteSpace(sentence))
                throw new Exception("Sentence contains no content");
            File.WriteAllText(filename, sentence);
        }

        public static string LoadText(string filename) { 
            if(!File.Exists(filename))
                throw new Exception("File specified, but not found");
            string result = File.ReadAllText(filename);
            return result;
        }
    }
}

/*
In your Program.cs file, inside your Question03 namespace and outside the Program class, create a new static class called TextService. 
In this class, implement two static methods: SaveText and LoadText.

The first method, SaveText, is intended to write a specified text to the hard drive as a text file (.txt), in a specified location. 
It takes two parameters: A string containing the text to be saved, and a string that defines the full physical path of the file that will be created (i.e. C:\MyFolder\Example.txt). 
Make sure your method handles line breaks properly.

The second method, LoadText, is intended to read and return all text from a specified text file. 
It should take only one parameter: A string containing the full physical path to the file that will be loaded (i.e. C:\MyFolder\Example.txt). 
Note that you may need to read multiple lines.


Once you are done, write the test harness in the Main method of your Program class, ensuring both methods are fully demonstrated. 
In other words, call the first method to write a file to your hard drive, and afterwards, call the second method to read the very file you have just created 
(do include a Console.WriteLine at the end to display the text you have just loaded). 

Your code must be tested with a text where the number of lines is determined by the last digit of your student number. 
For example, if the last digit of your student number is 1, your text should have 1 line. 
If the last digit of your student number is 2, your text should have 2 lines. If the last digit of your student number is 0, your text should have 10 lines. 
The content of this text can be creatively defined by you. 
You can choose anything, from movie names, to your favorite songs, or famous quotes.
 */