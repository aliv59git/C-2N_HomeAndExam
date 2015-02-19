using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.BinaryShort
{
    class Program
    {
        //•	Write a program that shows the binary representation of given 16-bit signed 
        //    integer number (the C# type short)

        static string SignedShortToBinary(short number)
        {
            string result = String.Empty;
            bool isSigned = false;
            if (number < 0)
            {
                isSigned = true;
                number = (short)(32768 + number);
            }
            while (number > 0)
            {
                result += number % 2;
                number /= 2;
            }
            char[] resA = result.ToCharArray();
            string result1 = String.Empty;
            string res1 = String.Empty;
            if (!isSigned)
            {
                res1 = string.Join("", resA.Reverse()).PadLeft(16, '0');
                result1 = res1;
            }
            else if (isSigned)
            {
                res1 = string.Join("", resA.Reverse()).PadLeft(15, '0');
                result1 = 1 + res1;
            }
            
            return result1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 16-bit signed intiger number: ");
            short numb = short.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(SignedShortToBinary(numb));
        }
    }
}
