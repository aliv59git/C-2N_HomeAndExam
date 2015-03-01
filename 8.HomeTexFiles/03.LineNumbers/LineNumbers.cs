using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LineNumbers
{

    //•	Write a program that reads a text file and inserts line numbers in front of each of its lines.
    //•	The result should be written to another text file.



    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\License.txt");
        StreamWriter writer = new StreamWriter(@"..\..\test.txt");
        using (strReader)
        {
            string tmpLine = strReader.ReadLine();
            int count = 1;
            using (writer)
            {
                while (tmpLine != null)
                {
                    writer.Write("{0:D2}   ", count);
                    writer.WriteLine(tmpLine);
                    count++;
                    tmpLine = strReader.ReadLine();
                }
            }
        }
        StreamReader strReader1 = new StreamReader(@"..\..\test.txt");
        Console.WriteLine(strReader1.ReadToEnd());
        strReader1.Close();
    }
}
