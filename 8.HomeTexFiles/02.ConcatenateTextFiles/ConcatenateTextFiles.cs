using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConcatenateTextFiles
{
    //•	Write a program that concatenates two text files into another text file.
    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\License.txt");
        StreamReader strReader1 = new StreamReader(@"..\..\ConcatenateTextFiles.cs");
        StreamWriter writer = new StreamWriter(@"..\..\test.txt");
        using (writer)
        {
            writer.WriteLine(strReader.ReadToEnd() + strReader1.ReadToEnd());
        }
        strReader1.Close();
        strReader.Close();
    }
}
