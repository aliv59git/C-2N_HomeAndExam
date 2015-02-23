using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractSentences
{
    //•	Write a program that extracts from a given text all sentences containing given word.
    static string ExtractSentencesContainingWord(string text, string word)
    {
        StringBuilder sentencesWithWord = new StringBuilder();
        StringBuilder chars = new StringBuilder();
        for (int j = 32; j < 123; j++)
        {
            char ch = (char)j;
            if (!Char.IsLetter(ch))
            {
                chars.Append(ch);
            }
        }
        char[] nonLetters =chars.ToString().ToCharArray();

        string[] sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < sentences.Length; i++)
        {
            string[] temp = sentences[i].Split(nonLetters, StringSplitOptions.RemoveEmptyEntries);
            foreach (string tm in temp)
            {
                if (tm == word)
                {
                    sentencesWithWord.Append(sentences[i]+".");
                }
            }
        }

        string result = string.Join("", sentencesWithWord.ToString());

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Please, enter word: ");
        string word = Console.ReadLine();
        Console.WriteLine(ExtractSentencesContainingWord(text, word));
    }
}
