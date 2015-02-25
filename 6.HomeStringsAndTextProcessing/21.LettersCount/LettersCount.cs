using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LettersCount
{
    //•	Write a program that reads a string from the console and prints all different letters 
    //    in the string along with information how many times each letter is found.

    static string LetterCount(string str)
    {
        StringBuilder sb = new StringBuilder();
        char[] charCount = new char[65536];
        int[] count = new int[65536];
        for (int i = 0; i < str.Length; i++)
        {
            charCount[(int)str[i]] = str[i];
            count[(int)str[i]]++;
        }
        for (int i = 0; i < count.Length; i++)
        {
            if (Char.IsLetter(charCount[i]))   // for all symbols in str:  if (count[i] !=0 )
            {
                sb.Append(charCount[i]);
                string temp = string.Empty;
                if (count[i] == 1)
                {
                    temp = string.Format("({0} time), ", count[i]);
                }
                else
                {
                    temp = string.Format("({0} times), ", count[i]);
                } 
                sb.Append(temp);
            }
        }
        return sb.ToString();
    }

        static void Main(string[] args)
    {
        Console.WriteLine("Please, enter string: ");
        string str = Console.ReadLine();
        Console.WriteLine(LetterCount(str));
    }
}
