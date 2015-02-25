using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        //Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
        static string ExtractTextFromHTMLDoc(string str) 
        {
            string str1 = str.Replace("<title>", "Title: ");
            string str2 = str1.Replace("</title>", "\n");
            string str3 = str2.Replace("<body>", "Text: ");
            bool isOpen = true;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str3.Length; i++)
            {
                if (str3[i] == '<')
                {
                    isOpen = true;
                }
                else if (str3[i] == '>')
                {
                    isOpen = false;
                }
                if (isOpen==false)
                {
                    if((str3[i] !='<')&&(str3[i]!='>'))
                    {
                        sb.Append(str3[i]);
                    }
                }
            }
            sb.Replace("  ", " ");
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter HTML Document: ");
            string str = Console.ReadLine();
            string str1 = str.Replace("\n\r", "");
            Console.WriteLine(ExtractTextFromHTMLDoc(str1));
        }
    }
}

/*
<html> <head><title>News</title></head> <body><p><a href="http://academy.telerik.com">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>
*/