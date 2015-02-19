using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.HexadecimalToBinary
{
    class Program
    {
        //•	Write a program to convert hexadecimal numbers to binary numbers (directly).

        static int HexadecimalToDecimal(string str)
        {
            int result = 0;
            int multiplyer = 1;
            for (int i = str.Length - 1; i >= 0; i--)
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

                result += digit * multiplyer;
                multiplyer *= 16;
            }
            return result;
        }

        static string DecimalToBinary(int number)
        {
            if (number < 0)
            {
                number = -number;
            }
            // result = "";
            List<int> numb = new List<int>();
            while (number > 0)
            {
                numb.Add(number % 2);
                number /= 2;
            }
            numb.Reverse();
            string result = string.Join("", numb);
            return result;
        }

        static string HexadecimalToBinary(string str)
        {
            int numb = HexadecimalToDecimal(str);
            string result = DecimalToBinary(numb);
            return result;
        }

        static string HexadecimalToBinaryDirect(string str) //direct conversion Hexadecimal -> Binary
        {
            string result = String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'A': result += "1010"; break;
                    case 'B': result += "1011"; break;
                    case 'C': result += "1100"; break;
                    case 'D': result += "1101"; break;
                    case 'E': result += "1110"; break;
                    case 'F': result += "1111"; break;
                    case '9': result += "1001"; break;
                    case '8': result += "1000"; break;
                    case '7': result += "0111"; break;
                    case '6': result += "0110"; break;
                    case '5': result += "0101"; break;
                    case '4': result += "0100"; break;
                    case '3': result += "0011"; break;
                    case '2': result += "0010"; break;
                    case '1': result += "0001"; break;
                    case '0': result += "0000"; break;
                    default: Console.WriteLine("Wrong number!"); break;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter hexadecimal numbrt");
            string str = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hexadecimal {0} to binary number is: {1}", str, HexadecimalToBinary(str));
            Console.WriteLine("To 32 bits: ");
            Console.WriteLine(HexadecimalToBinary(str).PadLeft(32, '0'));
            Console.WriteLine();
            Console.WriteLine("Hexadecimal {0} to binary number (directly) is: {1}", str, HexadecimalToBinaryDirect(str));
        }
    }
}
