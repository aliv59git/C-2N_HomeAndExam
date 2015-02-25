using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
    //•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
    static string isPalindrom(string text)
    {
        StringBuilder sbPal = new StringBuilder();
        string[] textW = text.Split(' ', ',', '.', '!', '?', ':', ';', '-', '_');
        for (int i = 0; i < textW.Length; i++)
        {
            bool isPalindrom = false;
            string word = textW[i];
            for (int j = 0; j < word.Length / 2; j++)
            {
                if ((word[j] == word[word.Length - 1 - j]))
                {
                    isPalindrom = true;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }
            }
            if (isPalindrom)
            {
                sbPal.Append(word+" ");
            }
        }
        
        return sbPal.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a text:");
        string text = Console.ReadLine();
        Console.WriteLine("Palindromes are: ");
        Console.WriteLine(isPalindrom(text));
    }
}
