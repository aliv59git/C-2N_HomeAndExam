using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsCount
{
    //•	Write a program that reads a string from the console and lists all different 
    //    words in the string along with information how many times each word is found.

    static string WordCount(string str)
    {
        string[] allWords = str.Split(new char[] { ' ', '.', ',', '\n', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        int[] count = new int[allWords.Length];
        StringBuilder sbWords = new StringBuilder(allWords.Length);
        sbWords.Append(allWords[0]);
        for (int i = 1; i < allWords.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (allWords[i] == sbWords[j])
                {
                    count[i]++;
                }
                else
                {
                    sbWords.Append(temp);
                }

            }
        
        
        }




    }
    
    static void Main(string[] args)
    {


    }
}
