using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

class OddLines
{
    //•	Write a program that reads a text file and prints on the console its odd lines.

    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\License.txt");
        int count = 0;
        string currentLine = strReader.ReadLine();
        using (strReader)
        {
            while (currentLine != null)
            {
                count++;
                currentLine = strReader.ReadLine();
                if (count % 2 == 1)
                {
                    Console.WriteLine("{0:D2}. {1}", count, currentLine);
                }
            }
        }
    }
}
