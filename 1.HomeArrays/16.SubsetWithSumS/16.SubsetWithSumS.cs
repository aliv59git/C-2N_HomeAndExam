using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SubsetWithSumS
{
    class Program
    {

//•	We are given an array of integers and a number S.
//•	Write a program to find if there exists a subset of the elements of the array that has a sum S.

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elemets of an array of intigers, separated by comma and space");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            Console.WriteLine("Please, enter sum S = ");
            int s = int.Parse(Console.ReadLine());
            int bestSum = s;
            int currentSum = 0;
            bool success = false;
            List<int> bestSubset = new List<int>();
            int t = 1;
            for (int k = 0; k < arr.Length; k++)
            {
                t *= 2;
            }
            for (int i = 0; i < t; i++)
            {
                string temp = Convert.ToString(i, 2);
                currentSum = 0;
                for (int j=0; j<temp.Length; j++)
                {
                    int mask = 1 << j;
                    int bit = (i & mask) >> j;
                    if (bit == 1)
                    {
                        currentSum += arr[j];
                        bestSubset.Add(arr[j]);
                    }
                }
                if (currentSum == bestSum)
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
