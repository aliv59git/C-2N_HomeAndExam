using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.PermutationsOfSet
{
    class Program
    {
//•	Write a program that reads a number N and generates and 
//    prints all the permutations of the numbers [1 … N].
        static int n, k, i;
        static int[] arr;


        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter integer number n:");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i+1;
            }
            Perm(n - 1);
        }

        static void Perm(int k)
        {
            if (k == 0)
            {
                PrintArr();
                return;
            }

            for (int j = 0; j < k; j++)
            {
                arr[j] += arr[k];
                arr[k] = arr[j] - arr[k];
                arr[j] = arr[j] - arr[k];
                Perm(k - 1);
                arr[j] += arr[k];
                arr[k] = arr[j] - arr[k];
                arr[j] = arr[j] - arr[k];
            }

            Perm(k - 1);
        }

        static void PrintArr()
        {
            Console.Write("{ ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write(" }");
            Console.WriteLine();
        }
    }
}
