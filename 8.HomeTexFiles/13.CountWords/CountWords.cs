using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class CountWords
{
    //•	Write a program that reads a list of words from the file words.txt and finds how many times each of the 
    //    words is contained in another file test.txt.
    //•	The result should be written in the file result.txt and the words should be sorted by the number of their 
    //    occurrences in descending order.
    //•	Handle all possible exceptions in your methods.

    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\test.txt");
        string[] words = File.ReadAllLines(@"..\..\words.txt");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        string line = strReader.ReadLine();
        while (line != null)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string regex = @"\b" + words[i] + @"\b";
                MatchCollection matches = Regex.Matches(line, regex, RegexOptions.IgnoreCase);
                if (dictionary.ContainsKey(words[i]))
                {
                    dictionary[words[i]] += matches.Count;
                }
                else
                {
                    dictionary.Add(words[i], matches.Count);
                }
            }
            line = strReader.ReadLine();
        }
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (writer)
        {
            foreach (var wordCount in dictionary.OrderByDescending(key => key.Value))
            {
                writer.WriteLine("{0} - {1}", wordCount.Key, wordCount.Value);
            }
            Console.WriteLine("Please, check result.txt");
        }
    }
}
