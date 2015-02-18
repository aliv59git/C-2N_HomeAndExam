using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BinaryToHexadecimal
{
    class Program
    {
       // •	Write a program to convert binary numbers to hexadecimal numbers (directly).

        static string BinaryToHexadecimalDirect(string str)
        {
            string result = String.Empty;
            string str1 = String.Empty;
            if ((str.Length % 4) != 0)
            {
                switch (str.Length % 4)
                {
                    case 1: str1 = "000" + str; break;
                    case 2: str1 = "00" + str; break;
                    case 3: str1 = "0" + str; break;
                    default: Console.WriteLine("InvalidNumber!"); break;
                }
            }
            else
            {
                str1 = str;
            }
            int devider = str1.Length / 4;
            for (int i = 0; i < devider; i++)
            {
                string temp = str1.Substring(0 + 4 * i, 4);
                switch (temp)
                {
                    case "0000": result += "0"; break;
                    case "0001": result += "1"; break;
                    case "0010": result += "2"; break;
                    case "0011": result += "3"; break;
                    case "0100": result += "4"; break;
                    case "0101": result += "5"; break;
                    case "0110": result += "6"; break;
                    case "0111": result += "7"; break;
                    case "1000": result += "8"; break;
                    case "1001": result += "9"; break;
                    case "1010": result += "A"; break;
                    case "1011": result += "B"; break;
                    case "1100": result += "C"; break;
                    case "1101": result += "D"; break;
                    case "1110": result += "E"; break;
                    case "1111": result += "F"; break;
                    default: Console.WriteLine("Invalid number!"); ; break;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter hexadecimal numbrt");
            string str = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Binary {0} to hexadecimal number (directly) is: {1}", str, BinaryToHexadecimalDirect(str));
        }
    }
}
