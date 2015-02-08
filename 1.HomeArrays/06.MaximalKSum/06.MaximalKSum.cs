using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaximalKSum
{
    class Program
    {
    // •	Write a program that reads two integer numbers N and K and an array of N elements from the console.
    //•	Find in the array those K elements that have maximal sum.

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger n, k and other n numbers (in separated lines):");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            long sum = 0;
            for (int j = 0; j < k; j++)
            {
                int bestNumber = int.MinValue;
                foreach (int numb in arr)
                {
                    if (numb > bestNumber)
                    {
                        bestNumber = numb;
                    }
                }
                Console.Write("{0}, ", bestNumber);
                sum += bestNumber;
                int index = Array.IndexOf(arr, bestNumber);
                arr[index] = int.MinValue;
            }
            Console.WriteLine();
            Console.WriteLine("The maximal sum of {0} elemets of an array is: {1}.", k, sum);
        }
    }
}
