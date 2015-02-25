using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SeriesOfLetters
{
    //•	Write a program that reads a string from the console and replaces all series of consecutive identical 
    //    letters with a single one.

    static string ReplacingConsecutiveIdenticalLetters(string str)
    {
        StringBuilder sb = new StringBuilder();
        char firstLetter = str[0];
        sb.Append(firstLetter);
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != firstLetter)
            {
                firstLetter = str[i];
                sb.Append(firstLetter);
            }
        }
        return sb.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a string: ");
        string str = Console.ReadLine();
        Console.WriteLine(ReplacingConsecutiveIdenticalLetters(str));
    }

    public static char[] firstLetter { get; set; }
}
