using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractE_mails
{
    //•	Write a program for extracting all email addresses from given text.
    //•	All sub-strings that match the format @… should be recognized as emails.



    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter text: ");
        string text = Console.ReadLine();
        string[] textFragments = text.Split(' ', ';', ',');
        for (int i = 0; i < textFragments.Length; i++)
        {
            if (textFragments[i].Contains("@"))
            {
                Console.WriteLine(textFragments[i]);
            }
        }



    }
}
