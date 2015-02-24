using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForbiddenWords
{
//•	We are given a string containing a list of forbidden words and a text containing 
//    some of these words.
//•	Write a program that replaces the forbidden words with asterisks.

    static string ReplaceForbiddenWords(string text, string forbiddenWords)
    {
        StringBuilder changedText = new StringBuilder(text);
        string result = string.Empty;
        string[] forbiddenW = forbiddenWords.Split(new char[]{ ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < forbiddenW.Length; i++)
        {
            changedText.Replace(forbiddenW[i], new string('*', forbiddenW[i].Length));
        }
        result = changedText.ToString();

        return result;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Please, enter forbidden words: ");
        string words = Console.ReadLine();
        Console.WriteLine("Text result is: {0}", ReplaceForbiddenWords(text, words));
    }
}
