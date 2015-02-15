using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AppearanceCount
{
    class Program
    {
//        •	Write a method that counts how many times given number appears in given array.
//•	Write a test program to check if the method is workings correctly.

        static int AppearanceCount(int[] array, int number)
        {
            int result = 0;
            foreach (int numb in array)
            {
                if (number == numb)
                {
                    result++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger numbers, separated by comma and space:");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int [str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            Console.Write("Please, enter intiger number N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} appears in the array of numbers {1} times.", n, AppearanceCount(arr, n));
        }
    }
}
