using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BinaryToDecimal
{
    class Program
    {
        //•	Write a program to convert binary numbers to their decimal representation.

        static long BinaryToDecimal(string binNumber)
        {
            long result = 0;
            int multiplyer = 1;
            for (int i = binNumber.Length-1; i >=0; i--)
            {
                if (binNumber[i]-48 == 1) 
                {
                    result += multiplyer;
                    multiplyer *= 2;
                }
                else
                {
                    multiplyer *= 2;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter binary number: ");
            string str = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(str));
        }
    }
}
