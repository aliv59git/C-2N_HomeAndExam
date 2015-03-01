using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareTextFiles
{
    //•	Write a program that compares two text files line by line and prints the number of lines that are the 
    //    same and the number of lines that are different.
    //•	Assume the files have equal number of lines.

    static void Main(string[] args)
    {
        StreamReader strReader1 = new StreamReader(@"..\..\test.txt");
        StreamReader strReader2 = new StreamReader(@"..\..\License.txt");
        using (strReader1)
        {
            using (strReader2)
            {
                string line1 = strReader1.ReadLine();
                string line2 = strReader2.ReadLine();
                int count = 1;
                List<int> theSame = new List<int>();
                List<int> different = new List<int>();
                while (line1 != null)
                {
                    if (line1 == line2)
                    {
                        theSame.Add(count);
                    }
                    else
                    {
                        different.Add(count);
                    }
                    count++;
                    line1 = strReader1.ReadLine();
                    line2 = strReader2.ReadLine();
                }
                Console.WriteLine("These lines are equal: "+string.Join(", ", theSame));
                Console.WriteLine("These lines are different: "+string.Join(", ", different));
            }
        }

    }
}
