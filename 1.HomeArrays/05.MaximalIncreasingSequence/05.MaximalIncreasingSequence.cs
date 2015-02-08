using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaximalIncreasingSequence
{
    class Program
    {
        //•	Write a program that finds the maximal increasing sequence in an array.
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elements of an array, separated by comma and space: ");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            for (int k = 0; k < str.Length; k++)
            {
                arr[k] = int.Parse(str[k]);
            }
            int currnetSequence = 1;
            int bestSequence = 0;
            int initialElement = arr[0];
            int initial = arr[0];
            int firstElement = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int currentEl = arr[i];
                if (currentEl > firstElement)
                {
                    currnetSequence++;
                    firstElement = currentEl;
                    if (bestSequence < currnetSequence)
                    {
                        bestSequence = currnetSequence;
                        initial = initialElement;
                    }
                }
                else
                {
                    firstElement = currentEl;
                    initialElement = currentEl;
                    currnetSequence = 1;
                }
            }
            int indexInitial = Array.IndexOf(arr, initial);
            for (int j = 0; j < bestSequence; j++)
            {
                Console.Write("{0}, ", arr[j+indexInitial]);
            }
            Console.WriteLine();
        }
    }
}
