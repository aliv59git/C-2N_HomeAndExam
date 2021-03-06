﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntigerCalculations
{
    class Program
    {
        //•	Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        //•	Use variable number of arguments.

        static int MaxNumber(int[] array = null)
        {
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > result)
                {
                    result = array[i];
                }
            }
            return result;
        }
        static int MinNumber(int[] array = null)
        {
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < result)
                {
                    result = array[i];
                }
            }
            return result;
        }
        static double Average(int[] array = null)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return (double)result/array.Length;
        }
        static int SumOfNumbers(int[] array = null)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }
        static long ProductOfNumbers(int[] array = null)
        {
            long result = 1;
            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elements af an intiger array, separated by comma and space: ");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Maximal element is: {0}", MaxNumber(arr));
            Console.WriteLine();
            Console.WriteLine("Minimal element is: {0}", MinNumber(arr));
            Console.WriteLine();
            Console.WriteLine("Aveage is: {0}", Average(arr));
            Console.WriteLine();
            Console.WriteLine("Sum of elements is: {0}", SumOfNumbers(arr));
            Console.WriteLine();
            Console.WriteLine("Product elemensts is: {0}", ProductOfNumbers(arr));
        }
    }
}
