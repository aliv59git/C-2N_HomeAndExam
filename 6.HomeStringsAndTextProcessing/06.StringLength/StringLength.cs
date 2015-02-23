using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringLength
{
    //•	Write a program that reads from the console a string of maximum 20 characters. 
    //    If the length of the string is less than 20, the rest of the characters should be 
    //        filled with *.
    //•	Print the result string into the console.


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter string with up to 20 characters: ");
        string str = Console.ReadLine();
        int aditional = 20 - str.Length;
        Console.WriteLine(str + new string('*', aditional));
    }
}
