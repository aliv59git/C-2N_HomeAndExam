using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class Program
    {
        //•	Write a program that finds the index of given element in a sorted 
        //    array of integers by using the Binary search algorithm.

        static int BinarySearch(int[] arr, int bestNumber)
        {
            int low = 0;
            int high = arr.Length - 1;
            int midpoint = 0;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;
                if (bestNumber == arr[midpoint])
                {
                    return midpoint;
                }
                else if (bestNumber < arr[midpoint])
                {
                    high = midpoint - 1;
                }
                else 
                { 
                    low = midpoint + 1;
                }
            }
            // if item was not found
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elemets of a sorted array, separated by comma and space");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            Console.WriteLine("Please, enter number (element, whose index to search): ");
            int bestNumber = int.Parse(Console.ReadLine());
            int midpoint = BinarySearch(arr, bestNumber);
            Console.WriteLine(midpoint);
        }
    }
}
