using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareStrings
{
    static void Main(string[] args)
    {
        string[] texts = { "6", "2", "4", "-1", "3" };
        string minText = texts[0];
        for (int i = 1; i < texts.Length; i++)
        {
            if (string.Compare(minText, texts[i], false) > 0)
            {
                minText = texts[i];
            }
        }
        Console.WriteLine(minText);

    }
}
