using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.DecimalToHexadecimal
{
    class Program
    {
        //	Write a program to convert decimal numbers to their hexadecimal representation.

        static string DecimalToHexadecimal(long number)
        {
            string result = String.Empty;
            while (number > 0)
            {
                switch (number % 16)
                {
                    case 10: result += "A"; break;
                    case 11: result += "B"; break;
                    case 12: result += "C"; break;
                    case 13: result += "D"; break;
                    case 14: result += "E"; break;
                    case 15: result += "F"; break;
                    default: result += number % 16; break;
                }
                number /= 16;
            }
            
            return string.Join("", result.ToCharArray().Reverse());
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger number: ");
            long numb = long.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0} to hexadecimal is: {1}", numb, DecimalToHexadecimal(numb));
        }
    }
}
