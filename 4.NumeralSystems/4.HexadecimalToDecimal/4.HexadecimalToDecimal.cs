using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HexadecimalToDecimal
{
    class Program
    {
        //•	Write a program to convert hexadecimal numbers to their decimal representation.

        static ulong HexadecimalToDecimal(string str)
        {
            ulong result = 0;
            ulong multiplyer = 1;
            for (int i = str.Length-1; i >=0; i--)
            {
                int digit = 0;
                char ch = str[i];
                switch (ch)
                {
                    case 'A': digit = 10; break;
                    case 'B': digit = 11; break;
                    case 'C': digit = 12; break;
                    case 'D': digit = 13; break;
                    case 'E': digit = 14; break;
                    case 'F': digit = 15; break;
                    default: digit = ch - '0'; break;
                }

                result += (ulong)digit * multiplyer;
                multiplyer *= 16;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter hexadecimal numbrt");
            string str = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hexadecimal {0} to decimal number is: {1}", str, HexadecimalToDecimal(str));
        }
    }
}
