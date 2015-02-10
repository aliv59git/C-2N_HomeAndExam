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
            int bestInitialIndex = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                int currentCount = 1;
                int left = arr[j];
                for (int k = j+1; k < arr.Length; k++)
                {
                    int right = arr[k];
                    if (left <= right)
                    {
                        currentCount++;
                    }
                }
               if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestInitialIndex = j;
                }
            }
            for (int u = bestInitialIndex; u < arr.Length; u++)
            {
                bestSequence.Add(arr[u]);
            }
            //has bestsequence increasing order?
            bool isIncreasing = false;
            while (isIncreasing != true)
            {
                for (int t = bestInitialIndex; t < arr.Length - 1; t++)
                {
                    if (!(arr[t] <= arr[t + 1]))
                    {
                        isIncreasing = false;
                    }
                    else
                    {
                        isIncreasing = true;
                    }
               }

                int temp = bestSequence.Max();
                Console.WriteLine(temp);
                bestSequence.Remove(temp);
                int temp1 = bestSequence.Min();
                bestSequence.Remove(temp1);
                Console.WriteLine(temp1);
            } 

            //int m = 2;
            //int first = bestInitialIndex;
            //int second, third;
            //while (bestInitialIndex+m<arr.Length)
            //{
            //    first += (m-2);
            //    second = first + m-1;
            //    third = first + m;
            //    if (arr[second] >= arr[first] && arr[third] >= arr[second])
            //    {
            //        bestSequence.Add(arr[second]);
            //        m++;
            //    }
            //    else if ((arr[second] > arr[first]) && ((arr[third] < arr[second]) && (arr[third] >= arr[first])))
            //    {
            //        bestSequence.Add(arr[third]);
            //        m += 2;
            //    }





            //} 



            Console.WriteLine(string.Join(", ", bestSequence));
        }
    }
}
