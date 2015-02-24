using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
//•	Write a program that converts a string to a sequence of C# Unicode character literals.
//•	Use format strings.

    static string stringToUnicode(string str)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char ch in str)
        {
            sb.Append(string.Format("\\u{0:X4}", (int)ch));
        }
        return sb.ToString();
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter a string to convert: ");
        string str = Console.ReadLine();
        Console.WriteLine(stringToUnicode(str));
    }
}
