using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GetLargestNumber
{
    class Program
    {
//        •	Write a method GetMax() with two parameters that returns the larger of two integers.
//•	Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

        static int GetMax(int first, int second)
        {
            int result = first;
            if (second > first)
            {
                result = second;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter three intiger numbers, separated by space: ");
            string[] str = Console.ReadLine().Split(' ');
            int a1 = int.Parse(str[0]);
            int a2 = int.Parse(str[1]);
            int a3 = int.Parse(str[2]);
            int temp = GetMax(a1, a2);
            int result = GetMax(temp, a3);
            Console.WriteLine("The largest number is: \n{0}", result);
        }
    }
}
