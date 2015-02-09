using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class Program
    {

        //•	Write a program that sorts an array of integers using the Merge sort algorithm.

        public static void Merging(int[] arr, int left, int middle, int right)
        {
            int[] temp = new int[15];
            int i, leftEnd, numberOfElements, currentPosition;

            leftEnd = middle - 1;
            currentPosition = left;
            numberOfElements = right - left + 1;

            while ((left <= leftEnd) && (middle <= right))
            {
                if (arr[left] <= arr[middle])
                {
                    temp[currentPosition++] = arr[left++];
                }
                else
                    temp[currentPosition++] = arr[middle++];
            }

            while (left <= leftEnd) 
            { 
                temp[currentPosition++] = arr[left++];
            }
            while (middle <= right) 
            {
                temp[currentPosition++] = arr[middle++];
            }
            for (i = 0; i < numberOfElements; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }

        public static void MergeSort_Recursive(int[] arr, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = left + ((right - left) / 2);
                MergeSort_Recursive(arr, left, mid);
                MergeSort_Recursive(arr, (mid + 1), right);

                Merging(arr, left, (mid + 1), right);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger numbers of an array, separated by comma and space:");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            MergeSort_Recursive(arr, 0, arr.Length - 1);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
