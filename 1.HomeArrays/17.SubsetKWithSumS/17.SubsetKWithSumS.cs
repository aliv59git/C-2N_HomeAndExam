using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SubsetKWithSumS
{
    class Program
    {
//•	Write a program that reads three integer numbers N, K and S and an array of N elements 
//    from the console.
//•	Find in the array a subset of K elements that have sum S or indicate about its absence.


        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter three intiger numbers: n, k (k < n), sum S");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter elemets of an array of intigers, separated by comma and space");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            int currentSum = 0;
            bool success = false;
            List<int> bestSubset = new List<int>();
            int t = 1;
            for (int u = 0; u < arr.Length; u++)
            {
                t *= 2;
            }
            for (int i = 0; i < t; i++)
            {
                string temp = Convert.ToString(i, 2);
                currentSum = 0;
                for (int j = 0; j < temp.Length; j++)
                {
                    int mask = 1 << j;
                    int bit = (i & mask) >> j;
                    if (bit == 1)
                    {
                        currentSum += arr[j];
                        bestSubset.Add(arr[j]);
                    }
                }
                if (currentSum == s)
                {
                    Console.WriteLine(string.Join(", ", bestSubset));
                    success = true;
                }
                currentSum = 0;
                bestSubset.RemoveRange(0, bestSubset.Count);
            }
            if (!success)
            {
                Console.WriteLine("There is not subsequewnt with sum S.");
            }
        }
    }
}
