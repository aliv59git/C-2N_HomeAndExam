using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DecimalToBinary
{
    class Program
    {
//•	Write a program to convert decimal numbers to their binary representation.

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


        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter decimal number (integer):");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(number));
            Console.WriteLine("To 32 bits: ");
            Console.WriteLine(DecimalToBinary(number).PadLeft(32, '0'));
        }
    }
}
