using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NumberCalculations
{
    class Program
    {
//•	Modify your last program and try to make it work for any number type, not just integer 
//    (e.g. decimal, float, byte, etc.)
//•	Use generic method (read in Internet about generic methods in C#).


        static double MaxNumber(double[] array = null)
        {
            double result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > result)
                {
                    result = array[i];
                }
            }
            return result;
        }
        static double MinNumber(double[] array = null)
        {
            double result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < result)
                {
                    result = array[i];
                }
            }
            return result;
        }
        static double Average(double[] array = null)
        {
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result / array.Length;
        }
        static double SumOfNumbers(double[] array = null)
        {
            double result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }
        static double ProductOfNumbers(double[] array = null)
        {
            double result = 1;
            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elements af an array, separated by comma and space: ");
            string[] str = Console.ReadLine().Split(',');
            double[] arr = new double[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = double.Parse(str[i]);
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
