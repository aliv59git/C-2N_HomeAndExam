using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsCount
{
    //•	Write a program that reads a string from the console and lists all different 
    //    words in the string along with information how many times each word is found.

    static IDictionary<string, int> WordCount(string str)
    {
        string[] allWords = str.Split(new char[] { ' ', '.', ',', '\n', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> words = new Dictionary<string, int>();
        foreach (string word in allWords)
        {
            if (string.IsNullOrEmpty(word.Trim()))
            {
                continue;
            }
            int count;
            if (!words.TryGetValue(word, out count))
            {
                count = 0;
            }
            words[word] = count + 1;
        }
        return words;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a string: ");
        string str = Console.ReadLine();

        IDictionary<String, int> wordCountResult = WordCount(str);
        PrintResult(wordCountResult);
    }

    private static void PrintResult(IDictionary<string, int> wordCountResult)
    {
        foreach (KeyValuePair<string, int> word in wordCountResult)
        {
            Console.WriteLine("Word '{0}' occurs {1} time(s)", word.Key, word.Value);
        }
    }
}
