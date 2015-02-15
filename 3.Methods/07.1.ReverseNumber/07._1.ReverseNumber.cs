using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._1.ReverseNumber
{
    class Program
    {
        //•	Write a method that reverses the digits of given decimal number.
        static ulong ReverseNumber(ulong number)
        {
            List<int> numb = new List<int>();
            while (number > 0)
            {
                int temp = (int)(number % 10);
                numb.Add(temp);
                number /= 10;
            }
            ulong result = ulong.Parse(string.Join("", numb));
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter decimal number: ");
            ulong number = ulong.Parse(Console.ReadLine());
            ulong result = ReverseNumber(number);
            Console.WriteLine(result);
        }
    }
}
