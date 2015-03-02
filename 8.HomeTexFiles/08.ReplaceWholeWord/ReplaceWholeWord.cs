using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ReplaceWholeWord
{
    //•	Modify the solution of the previous problem to replace only whole words (not strings).
    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\fileInput.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (strReader)
        {
            using (writer)
            {
                string line = strReader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = strReader.ReadLine();
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
