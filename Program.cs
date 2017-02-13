using System;
using System.Collections.Generic;
using System.IO;

namespace WordRemember
{
    class Program
    {
        static void Main(string[] args)
        {
            // Attempt to get input and read it into an array.
            Console.WriteLine("What is the name of the file to read from? Use of a dictionary is preferable.");
            string inFile = Console.ReadLine();
            string[] words = System.IO.File.ReadAllLines(inFile);
          

            // List to hold matched words.
            List<string> matchedWords = new List<string>();

            // Get user input.
            Console.WriteLine("What does the word start with? (Enter to skip)");
            string sw = Console.ReadLine();
            Console.WriteLine("What does the word end with? (Enter to skip)");
            string ew = Console.ReadLine();
            Console.WriteLine("What letters or substrings are in the word? (Enter to skip, separate substrings with commas)");
            string[] contains = Console.ReadLine().Split(',', ' ');

            // Match words.
            foreach (var word in words)
            {
                if (word.StartsWith(sw) && word.EndsWith(ew))
                {
                    bool add = true;
                    foreach (var letter in contains)
                    {
                        if (!word.Contains(letter))
                        {
                            add = false;
                        }
                    }
                    if (add)
                    {
                        matchedWords.Add(word);
                    }
                }
            }

            // Output the file.
            Console.WriteLine("Where would you like to save your results?");
            string outFile = Console.ReadLine();
            System.IO.File.WriteAllLines(outFile, matchedWords);
            Console.WriteLine("File Written Successfully. Press any key to continue.");
            Console.ReadKey();
        }
    }
}