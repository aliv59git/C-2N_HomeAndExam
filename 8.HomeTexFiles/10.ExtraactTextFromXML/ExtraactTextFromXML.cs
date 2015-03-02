using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtraactTextFromXML
{
    //•	Write a program that extracts from given XML file all the text without the tags.

    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\tmp1.html");
        bool openTag = false;
        string lines = strReader.ReadToEnd();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i] == '<')
            {
                openTag = true;
            }
            if (lines[i] == '>')
            {
                openTag = false;
            }

            if (openTag == false)
            {
                if (lines[i] != '<' && lines[i] != '>')
                {
                    sb.Append(lines[i]);
                }
            }
        }
        sb.Replace("<", string.Empty).Replace(">", string.Empty).Replace("  ", " ").Replace("\n\n", "\n");
        strReader.Close();
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (writer)
        {
            writer.WriteLine(sb.ToString());
        }

        StreamReader strResult = new StreamReader(@"..\..\result.txt");
        string resLine = strResult.ReadLine();
        while (resLine != null)
        {
            Console.WriteLine(resLine);
            resLine = strResult.ReadLine();
        }
    }
}
