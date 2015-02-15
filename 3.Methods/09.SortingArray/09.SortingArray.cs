using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class Program
    {
        //•	Write a method that return the maximal element in a portion of array of integers starting at given index.
        //•	Using it write another method that sorts an array in ascending / descending order.

        static int MaximalElementInAPortionOfArray(int[] array, int startIndex)
        {
            int result = array[startIndex];
            for (int i = startIndex+1; i < array.Length; i++)
            {
                if (result < array[i])
                {
                    result = array[i];
                }
            }
            return result;
        }

        static void SortDescending(int[] arrayD)
        {
            for (int i = 0; i < arrayD.Length; i++)
            {
                int temp = MaximalElementInAPortionOfArray(arrayD, i);
                int tempIndex = Array.IndexOf(arrayD, temp);
                if (tempIndex != i)
                {
                    int tmp = arrayD[tempIndex];
                    arrayD[tempIndex] = arrayD[i];
                    arrayD[i] = tmp;
                }
            }
        }

        static void SortAscending(int[] arrayA)
        {
            SortDescending(arrayA);
            arrayA.Reverse();
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 2, 78, 34, 55, 66, 77, 88, 234, 456, 355, };
            Console.WriteLine(MaximalElementInAPortionOfArray(arr, 6));
            Console.WriteLine();
            int[] arrCopy1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrCopy1[i] = arr[i];
            }
            //SortAscending(arrCopy1);
            SortDescending(arr);
            Console.WriteLine(string.Join(", ", arrCopy1));
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
