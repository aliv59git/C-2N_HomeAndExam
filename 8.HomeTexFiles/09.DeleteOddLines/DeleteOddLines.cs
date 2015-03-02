using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DeleteOddLines
{
    //•	Write a program that deletes from given text file all odd lines.
    //•	The result should be in the same file.

    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\License.txt");
        List<string> strResult = new List<string>();
        string line = strReader.ReadLine();
        using (strReader)
        {
            int count = 1;
            while (line != null)
            {
                if (count % 2 == 0)
                {
                    strResult.Add(line);
                }
                line = strReader.ReadLine();
                count++;
            }
        }
        StreamWriter writer = new StreamWriter(@"..\..\License.txt");
        using (writer)
        {
            foreach (var item in strResult.ToArray())
            {
                 writer.WriteLine(item);
            }
        }
    }
}
