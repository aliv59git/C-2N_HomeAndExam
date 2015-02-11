using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.RemoveElementsFromArray
{
    class Program
    {
//•	Write a program that reads an array of integers and removes from it a minimal number of elements in such a way 
        //that the remaining array is sorted in increasing order.
//•	Print the remaining sorted array.
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elements of an array, separated by comma end space:");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            List<int> bestSequence = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            int bestCount = 0;
            int currentCount = 0;
            List<int> bestResult = new List<int>();
            int t = 1;
            for (int k = 0; k < arr.Length; k++)
            {
                t *= 2;
            }
            for (int i = 0; i < t; i++)
            {
                for (int k = 0; k < arr.Length; k++)
			    {
                    bestSequence.Add(arr[k]);
			    }
                string temp = Convert.ToString(i, 2);
                for (int j = 0; j < temp.Length; j++)
                {
                    int mask = 1 << j;
                    int bit = (i & mask) >> j;
                    if (bit == 1)
                    {
                        bestSequence.Remove(arr[j]);
                    }
                }
                //has bestSequence increasing order?
                bool isIncreasing = true;
                for (int j = 0; j < bestSequence.Count - 1; j++)
                {
                    if (!(bestSequence[j] <= bestSequence[j + 1]))
                    {
                        isIncreasing = false;
                    }
                }
                int[] arrNew = new int[bestSequence.Count];
                if (isIncreasing==true)
                {
                    currentCount = bestSequence.Count;
                    if (currentCount > bestCount)
                    {
                        bestResult.Clear();
                        bestCount = currentCount;
                        for (int u = 0; u < bestSequence.Count; u++)
                        {
                            bestResult.Add(bestSequence[u]);
                        }
                    }
                }
                currentCount = 0;
                bestSequence.Clear();
            }
            Console.WriteLine(string.Join(", ", bestResult));

        }
    }
}
