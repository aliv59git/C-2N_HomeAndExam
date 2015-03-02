using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class PrefixTest
{
    //•	Write a program that deletes from a text file all words that start with the prefix test.
    //•	Words contain only the symbols 0…9, a…z, A…Z, _.


    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\fileInput.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (strReader)
        {
            string words = strReader.ReadToEnd();
            using (writer)
            {
                writer.WriteLine(Regex.Replace(words, @"\b(test\w*)\b", string.Empty));
            }
        }
        StreamReader strResult = new StreamReader(@"..\..\result.txt");
        string lineR = strResult.ReadLine();
        while (lineR != null)
        {
            Console.WriteLine(lineR);
            lineR = strResult.ReadLine();
        }
    }
}
