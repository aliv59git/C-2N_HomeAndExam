using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinarySearch
{
    class Program
    {
        //•	Write a program, that reads from the console an array of N integers 
        //    and an integer K, sorts the array and using the method Array.BinSearch() 
        //finds the largest number in the array which is ≤ K.

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger N = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Please, enter N elements of an array, separated by comma and space:");
            string[] str = Console.ReadLine().Split(',');
            for (int i = 0; i < n; i++)
			{
                arr[i] = int.Parse(str[i]);
			}
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine("Please, enter intiger K = ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            int index = int.MinValue;
            if(k >= arr[n-1] || k <= arr[0])
            {
                index = n - 1;
                Console.WriteLine("Largest number <= K is: {0}", index);
            }
            int left = 0;
            int right = n - 1;
            while (left < right)
            {
                int middle = left + (right - left)/2;
                if (arr[middle] == k)
                {
                    Console.WriteLine("Largest number <= K is: {0}", middle);
                }
                else if (arr[middle] < k)
                {
                    left = middle;
                }
                else if (arr[middle] > k)
                {
                    right = middle;
                }
            }
            Console.WriteLine("Largest number <= K is: {0}", left);

            //index = Array.BinarySearch(arr, k);
            //Console.WriteLine(index);
        }
    }
}
