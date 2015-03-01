using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SaveSortedNames
{
    //•	Write a program that reads a text file containing a list of strings, sorts them and saves them to 
    //    another text file.

    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\License.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Result.txt");
        using (strReader)
        {
            string[] words = strReader.ReadToEnd().Split(new char[] { ' ', ',', '.', '\n', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            using(writer)
	        {
		        foreach (var item in words)
	            {
		            writer.WriteLine(item);
	            }
	        }
        }
        StreamReader strResult = new StreamReader(@"..\..\Result.txt");
        using (strResult)
        {
            Console.WriteLine(strResult.ReadToEnd());
        }
    }
}
