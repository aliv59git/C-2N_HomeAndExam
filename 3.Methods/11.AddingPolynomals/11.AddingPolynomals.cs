using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AddingPolynomals
{
    class Program
    {
        //•	Write a method that adds two polynomials.
        //•	Represent them as arrays of their coefficients
        static int[] AddOfTwoPolynomals(int[] arr1, int[] arr2)
        {
            int len = Math.Max(arr1.Length, arr2.Length);
            int[] result = new int[len];
            if(arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (i < arr1.Length - arr2.Length)
                    {
                        result[i] = arr1[i];
                    }
                    else if(i>= arr1.Length - arr2.Length)
                    {
                        result[i] = arr1[i] + arr2[i - (arr1.Length - arr2.Length)];
                    }
                }
            }
            else if(arr2.Length > arr1.Length) 
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (j < arr2.Length - arr1.Length)
                    {
                        result[j] = arr2[j];
                    }
                    else if (j >= arr2.Length - arr1.Length)
                    {
                        result[j] = arr2[j] + arr1[j - (arr2.Length - arr1.Length)];
                    }
                }               
            }

            return result;
        }



        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 2, 5, 0, 4, 1 };
            int[] arr2 = new int[3] { 2, 4, 1 };
            Console.WriteLine("{ " + string.Join(", ", AddOfTwoPolynomals(arr1, arr2)) + " }");
        }
    }
}
