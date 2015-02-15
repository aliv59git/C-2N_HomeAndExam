using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseNumber
{
    class Program
    {
        //•	Write a method that reverses the digits of given decimal number.
        static decimal ReverseNumber(decimal number)
        {
            decimal result = 0;
            string numb = number.ToString();
            char[] newNumb = new char[numb.Length];
            for (int i = 0; i < numb.Length; i++)
            {
                newNumb[i] = numb[i];
            }

            for (int j = 0; j < newNumb.Length / 2; j++)
            {
                char temp = newNumb[newNumb.Length - 1 - j];
                newNumb[newNumb.Length - 1 - j] = newNumb[j];
                newNumb[j] = temp;
            }
            string newNumber = string.Join("", newNumb);
            result = decimal.Parse(newNumber);
            return result;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter decimal number: ");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(number));

        }
    }
}
