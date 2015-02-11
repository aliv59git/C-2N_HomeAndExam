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

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter integer number n:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }


        }
    }
}
