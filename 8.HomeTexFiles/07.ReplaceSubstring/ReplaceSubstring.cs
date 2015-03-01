using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplaceSubstring
{
//    •	Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//•	Ensure it will work with large files (e.g. 100 MB).


    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\fileInput.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (strReader)
        {
            string temp = strReader.ReadLine();
            using (writer)
            {
                while (temp != null)
                {
                    string line = temp.Replace("start", "finish");
                    writer.WriteLine(line);
                    temp = strReader.ReadLine();
                }                
            }
        }
        StreamReader strResult = new StreamReader(@"..\..\result.txt");
        using (strResult)
        {
            string tempRes = strResult.ReadLine();
            while (tempRes != null)
            {
                Console.WriteLine(tempRes);
                tempRes = strResult.ReadLine();
            }
        }

    }
}
