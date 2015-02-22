using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    //•	Write a program to check if in a given expression the brackets are put correctly.

    static bool IsBracketsPutCorrectly(string str)
    {
        bool isCorrectly = true; 
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                count++;
            }
            else if (str[i] == ')')
            {
                count--;
            }
            if (count < 0)
            {
                isCorrectly = false;
                break;
            }
        }
        if (count != 0)
        {
            isCorrectly = false;
        }

        return isCorrectly;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter expression with brackets: ");
        Console.WriteLine("Is in a given expression the brackets are put correctly? {0}", IsBracketsPutCorrectly(Console.ReadLine()));
    }
}
