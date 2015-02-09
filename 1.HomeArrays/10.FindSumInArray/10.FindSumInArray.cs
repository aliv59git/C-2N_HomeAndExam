using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FindSumInArray
{
    class Program
    {
        //•	Write a program that finds in given array of integers a 
        //    sequence of given sum S (if present).
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elemets of an array, separated by comma and space");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            Console.WriteLine("Please, enter sum: ");
            int bestSum = int.Parse(Console.ReadLine());
            int bestFirstNumber = 0;
            int bestCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = arr[i];
                if (currentSum == bestSum)
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
                int count = 1;
                for (int j = i+1; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    count++;
                    if (currentSum == bestSum)
                    {
                        bestFirstNumber = i;
                        bestCount = count;
                        break;
                    }
                }
            }
            for (int k = bestFirstNumber; k < bestFirstNumber+bestCount; k++)
            {
                Console.Write("{0}, ", arr[k]);
            }
            Console.WriteLine();
            if (bestCount == 0)
            {
                Console.WriteLine("These is not a sequence with sum = {0} in this array.", bestSum);
            }
        }
    }
}
