using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.OneSystemToAnyOther
{
    class Program
    {
        //•	Write a program to convert from any numeral system of given base s to any other 
        //    numeral system of base d (2 ≤s, d ≤ 16).

        static ulong ConvertFromNumeralToDecimal(int s, string str)  //s = initialBase
        {
            ulong result = 0;
            int multiplyer = 1;
            for (int i = str.Length-1; i >=0 ; i--)
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

        static string ConvertFromDecimalToNumeral(int d, ulong number)  //d is targer Base
        {
            string result = String.Empty;
            while (number > 0)
            {
                int temp = (int)number % d;


            }





            return result;
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number in s-based system (2<=s<=16): ");
            string str = Console.ReadLine();
            Console.WriteLine("Plese, enter base s = ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertFromNumeralToDecimal(s, str));
        }
    }
}
