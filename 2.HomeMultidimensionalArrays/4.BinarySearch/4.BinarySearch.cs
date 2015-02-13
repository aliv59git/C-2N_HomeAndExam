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
            Console.WriteLine("Please, enter intiger K = ");
            int k = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            int index = -1;
            if(k >= arr[n-1])
            {
                index = n - 1;
                Console.WriteLine("Largest number <= K is: {0}", index);
            }
            else if (k < arr[0])
            {
                Console.WriteLine("There is not a number <=K in the array.");
            }
            while (index < 0)
            {
                index = Array.BinarySearch(arr, k);
                k--;
            }
            Console.WriteLine("Ordered array is: \n{0}", string.Join(", ", arr));
            Console.WriteLine("Largest number <= K is: {0} and it is at {1} position", arr[index], index);

        }
    }
}
