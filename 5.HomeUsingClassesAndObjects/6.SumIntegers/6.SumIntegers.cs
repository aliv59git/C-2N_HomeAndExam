using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //•	You are given a sequence of positive integer values written into a string, separated by spaces.
    //•	Write a function that reads these values from given string and calculates their sum.

    static int SumOfIntigers(string str)
    {
        int result = 0;
        string str1 = string.Join(", ", str.Split(' '));
        string[] strNumbers = str1.Split(',');
        for (int i = 0; i < strNumbers.Length; i++)
        {
            if (strNumbers[i] == " ")
            {
                strNumbers[i] += "0";
            }
            result += int.Parse(strNumbers[i]);
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter positive intiger values, separated by space/spaces: ");
        string str = Console.ReadLine();
        Console.WriteLine("The sum of intiger values is {0}", SumOfIntigers(str));
    }
}
