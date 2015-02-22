using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
   // •	Write a program that reads a string, reverses it and prints the result at the console.

    static string ReverseStr(string str)
    {
       char[] charStr = str.ToCharArray();
       return string.Join("", charStr.Reverse());
    }



    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter string to reverse: ");
        Console.WriteLine(ReverseStr(Console.ReadLine()));
    }
}
