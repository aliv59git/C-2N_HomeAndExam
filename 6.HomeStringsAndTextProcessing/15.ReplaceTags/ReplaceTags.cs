using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplaceTags
{
//•	Write a program that replaces in a HTML document given as string all 
//    the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

    static string ReplaceTags(string str)
    {
        string result = string.Empty;
        int startLetA = str.IndexOf("<a");
        int startLetQuote = str.IndexOf('\"');
        int endLetQuote = str.IndexOf("\">");


        return result;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter HTML document as string: ");
        string str = Console.ReadLine();

    }
}
