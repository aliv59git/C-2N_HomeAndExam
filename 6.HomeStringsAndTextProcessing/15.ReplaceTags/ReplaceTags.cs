using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplaceTags
{
    //•	Write a program that replaces in a HTML document given as string all 
    //    the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

    static string ReplaceTagsInHTML(string str)
    {
        StringBuilder sb = new StringBuilder();
        string result = string.Empty;
        int newBegin = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str.IndexOf("<a", i) != -1)
            {
                int startLetA = str.IndexOf("<a", i);
                int startLetQuote = str.IndexOf("=\"", i);
                int endLetQuote = str.IndexOf("\">", i);
                int startEndTag = str.IndexOf("</a", i);
                sb.Append(str.Substring(i, startLetA - newBegin));
                sb.Append("[URL=");
                sb.Append(str.Substring(startLetQuote+2, endLetQuote-startLetQuote-2));
                sb.Append("]");
                sb.Append(str.Substring(endLetQuote + 2, startEndTag - endLetQuote - 2));
                sb.Append("[/URL]");
                i = startEndTag + 3;
                newBegin = i+1;
            }
            else
            {
                sb.Append(str.Substring(i));
                break;
            }
        }
        result = sb.ToString();

        return result;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter HTML document as string: ");
        string str = Console.ReadLine();
        Console.WriteLine(ReplaceTagsInHTML(str));
    }
}
