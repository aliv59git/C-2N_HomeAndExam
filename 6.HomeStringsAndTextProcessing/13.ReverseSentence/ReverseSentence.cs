using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseSentence
{
    //•	Write a program that reverses the words in given sentence.

    static string ReverseWords(string str)
    {
        char end = str[str.Length - 1];
        string str1 = str.Remove(str.Length - 1);
        string[] words = str1.Split(' ');
        string reverseWords = string.Join(" ", words.Reverse());
        return (reverseWords + end.ToString());
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter sentence: ");
        string str = Console.ReadLine();
        Console.WriteLine(ReverseWords(str));
    }
}
