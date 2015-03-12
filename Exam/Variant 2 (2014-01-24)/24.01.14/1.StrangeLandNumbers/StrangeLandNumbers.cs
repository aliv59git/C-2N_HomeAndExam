using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class StrangeLandNumbers
{
    static ulong ConvertFromNumeralToDecimal(int s, string str)  //s = initialBase
    {
        ulong result = 0;
        int multiplyer = 1;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            switch (str[i])
            {
                case 'A': result += (ulong)(10 * multiplyer); multiplyer *= s; break;
                case 'B': result += (ulong)(11 * multiplyer); multiplyer *= s; break;
                case 'C': result += (ulong)(12 * multiplyer); multiplyer *= s; break;
                case 'D': result += (ulong)(13 * multiplyer); multiplyer *= s; break;
                case 'E': result += (ulong)(14 * multiplyer); multiplyer *= s; break;
                case 'F': result += (ulong)(15 * multiplyer); multiplyer *= s; break;
                default: result += (ulong)((str[i] - 48) * multiplyer); multiplyer *= s; break;
            }
        }
        return result;
    }


    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        char currentFLetter = input[0];
        int indexOfCurrentLetter = input.IndexOf(input[0]);
        while (true)
        {
            switch (currentFLetter)
            {
                case 'f':  sb.Append('0'); indexOfCurrentLetter += 1; break;
                case 'b': sb.Append('1'); indexOfCurrentLetter += 3; break;
                case 'o': sb.Append('2'); indexOfCurrentLetter += 5; break;
                case 'm': sb.Append('3'); indexOfCurrentLetter += 7; break;
                case 'l': sb.Append('4'); indexOfCurrentLetter += 6; break;
                case 'p': sb.Append('5'); indexOfCurrentLetter += 4; break;
                case 'h': sb.Append('6'); indexOfCurrentLetter += 2; break;
                default: Console.WriteLine("Invalid string"); break;
            }
            if (indexOfCurrentLetter < input.Length)
            {
                currentFLetter = input[indexOfCurrentLetter];
            }
            else
            {
                break;
            }
        }
        //Console.WriteLine(sb.ToString().TrimStart('0'));
        Console.WriteLine(ConvertFromNumeralToDecimal(7, sb.ToString().TrimStart('0')));

    }
}
