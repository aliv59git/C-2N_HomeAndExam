using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
    //•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a text:");
        string[] text = Console.ReadLine().Split(' ', ',', '.', '!', '?', ':', ';', '-', '_');
        Console.WriteLine("Palindromes are: ");
        for (int i = 0; i < text.Length; i++)
        {
            bool isPalindrom = false;
            string word = text[i];
            for (int j = 0; j < word.Length/2; j++)
            {
                if ((word[j] == word[word.Length - 1-j]))
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
                Console.WriteLine(word);
            }
        }
    }
}
