using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSort
{
    class Program
    {
        //•	Write a program that sorts an array of strings using the Quick sort algorithm.

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                    left++;

                while (arr[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public static void QuickSort_Recursive(int[] arr, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right);
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
            QuickSort_Recursive(arr, 0, arr.Length - 1);
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
