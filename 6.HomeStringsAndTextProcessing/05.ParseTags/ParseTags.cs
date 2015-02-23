using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseTags
{
    //•	You are given a text. Write a program that changes the text in all regions 
    //    surrounded by the tags <upcase> and</upcase> to upper-case.
    //•	The tags cannot be nested.

    static string ChangeToUpper(string str)
    {
        string result = string.Empty;
        StringBuilder sb = new StringBuilder();
        int strStart = str.IndexOf("<upcase>");
        int strEnd = str.IndexOf("</upcase>");
        for (int i = 0; i < str.Length; i++)
        {
            if (strStart != -1)
            {
                if (sb.Length == 0)
                {
                    sb.Append(str.Substring(0, strStart));
                }
                sb.Append(str.Substring(strStart+8, strEnd-strStart-8).ToUpper());
                i = strEnd + 1;
                strStart = str.IndexOf("<upcase>", i);
                if (strStart != -1)
                {
                    sb.Append(str.Substring(strEnd + 9, strStart - strEnd-9));
                }
                strEnd = str.IndexOf("</upcase>", i);
            }
            else 
            {
                strEnd = str.LastIndexOf(">");
                sb.Append(str.Substring(strEnd + 1));
                break;
            }
        }
        result = sb.ToString();
        return result;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter text with tags <upcase> and </upcase>: ");
        string str = Console.ReadLine();
        Console.WriteLine(ChangeToUpper(str));
    }
}
