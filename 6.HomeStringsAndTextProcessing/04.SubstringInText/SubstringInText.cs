using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubstringInText
{
    // •	Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

    static int SubstringInGivenText(string str, string substr)
    {
        int result = 0;
        str.ToLower();
        substr.ToLower();
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            int index = str.IndexOf(substr, i);
            if (index != -1)
            {
                result++;
            }
        }



        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter string: ");
        string str = Console.ReadLine();
        Console.WriteLine("Please, enter substring: ");
        string substr = Console.ReadLine();
        Console.WriteLine(SubstringInGivenText(str, substr));
    }
}
