using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.FrequentNumber
{
    class Program
    {
        // Write a program that finds the most frequent number in an array
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elemets of an array, separated by comma and space");
            string[] str = Console.ReadLine().Split(',');
            double[] arr = new double[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = double.Parse(str[i]);
            }
            int bestCount = 0;
            double bestNumber = arr[0];
            for (int j = 0; j < arr.Length; j++)
            {
                int count = 1;
                for (int k = 0; k < arr.Length; k++)
                {
                    if (k != j)
                    {
                        if (arr[j] == arr[k])
                        {
                            count++;
                        }
                    }
                }
                if (bestCount < count)
                {
                    bestCount = count;
                    bestNumber = arr[j];
                } 
            }
            Console.WriteLine("{0}({1} times)", bestNumber, bestCount);
        }
    }
}
