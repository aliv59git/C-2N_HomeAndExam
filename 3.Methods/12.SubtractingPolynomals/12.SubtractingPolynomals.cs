using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SubtractingPolynomals
{
    class Program
    {
//•	Extend the previous program to support also subtraction and multiplication of polynomials.
        static int[] SubtractingOfTwoPolynomals(int[] arr1, int[] arr2)
        {
            int len = Math.Max(arr1.Length, arr2.Length);
            int[] result = new int[len];
            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (i < arr1.Length - arr2.Length)
                    {
                        result[i] = arr1[i];
                    }
                    else if (i >= arr1.Length - arr2.Length)
                    {
                        result[i] = arr1[i] - arr2[i - (arr1.Length - arr2.Length)];
                    }
                }
            }
            else if (arr2.Length > arr1.Length)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (j < arr2.Length - arr1.Length)
                    {
                        result[j] = -arr2[j];
                    }
                    else if (j >= arr2.Length - arr1.Length)
                    {
                        result[j] = arr1[j - (arr2.Length - arr1.Length)] - arr2[j];
                    }
                }
            }

            return result;
        }

        static int[] MultiplicationOfTwoPolynomals(int[] arr1, int[] arr2)
        {
            int[] result1 = new int[arr1.Length + arr2.Length - 1];
            int l1 = arr1.Length;
            int l2 = arr2.Length;
            for (int i = l2-1; i >=0; i--)
            {
                for (int j = l1-1; j >=0; j--)
                {
                    result1[j + i] += arr2[i] * arr1[j];
                }
            }

            return result1;
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 2, 5, 0, 4, 1 };
            int[] arr2 = new int[3] { 2, 4, 1 };
            Console.WriteLine("Subtracting of two polynomas as arrays of their coefficients:  arr1 - arr2: ");
            Console.WriteLine("{ " + string.Join(", ", SubtractingOfTwoPolynomals(arr1, arr2)) + " }");
            Console.WriteLine();
            Console.WriteLine("Multiplication of two polynomas as arrays of their coefficients: arr1 * arr2");
            Console.WriteLine("{ " + string.Join(", ", MultiplicationOfTwoPolynomals(arr1, arr2)) + " }");
        }
    }
}

