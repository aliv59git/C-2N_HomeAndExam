using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.CombinationsOfSet
{
    class Program
    {
//•	Write a program that reads two numbers N and K and generates all the 
//    combinations of K distinct elements from the set [1..N].

        static int n, k;
        static int[] arr;

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integer numbers n and k (k < n):");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            arr = new int[k];
            NestedLoops();
        }

        static void PrintArr()
        {
            Console.Write("{ ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write(" }");
            Console.WriteLine();
        }

        static void NestedLoops()
        {
            InitLoops();
            int currentPosition;
            while (true)
            {
                bool isIncreasing = true;
                for (int u = 0; u < arr.Length-1; u++)
                {
                    if (arr[u+1] <= arr[u])
                    {
                        isIncreasing = false;
                    }
                }
                
                if (isIncreasing)
                {
                    PrintArr();
                }

                currentPosition = k - 1;
                arr[currentPosition]++;
                while (arr[currentPosition] > n)
                {
                    arr[currentPosition] = k;
                    currentPosition--;
                    if (currentPosition < 0)
                    {
                        return;
                    }
                    arr[currentPosition] += 1;
                }
            }
        }

        static void InitLoops()
        {
            for (int i = 0; i < k; i++)
            {
                arr[i] = i + 1;
            }
        }
    }
}
