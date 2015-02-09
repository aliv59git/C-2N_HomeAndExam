using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaximalSum
{
    class Program
    {
        // Write a program that finds the sequence of maximal sum in given array.
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elemets of an array, separated by comma and space");
            string[] str = Console.ReadLine().Split(',');
            double[] arr = new double[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(str[i]);
            }
            double maxSum = 0;
            int bestFirstElement = 0;
            int firstElement = 0;
            double currentSum = arr[0];
            int countSequenceLength = 1;
            int bestSeuenceLength = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (currentSum + arr[i] < 0)
                {
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        bestFirstElement = firstElement;
                        bestSeuenceLength = countSequenceLength;
                    }
                    firstElement = i + 1;
                    currentSum = 0;
                    countSequenceLength = 0;
                }
                else
                {
                    currentSum += arr[i];
                    countSequenceLength++;
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        bestFirstElement = firstElement;
                        bestSeuenceLength = countSequenceLength;
                    }
                }
            }
            for (int j = bestFirstElement; j < bestFirstElement+bestSeuenceLength; j++)
            {
                Console.Write("{0}, ", arr[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Maximal Sum is {0}.", maxSum);
        }
    }
}
