using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SelectionSort
{
    class Program
    {
        //•	Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        //•	Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest 
        //from the rest, move it at the second position, etc.

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elemets of an array, separated by space");
            string[] str = Console.ReadLine().Split(' ');
            double[] arr = new double[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(str[i]);
            }
            int index = -1;
            for (int j = 0; j < arr.Length; j++)
            {
                double minElement = arr[j];
                for (int k = j+1; k < arr.Length; k++)
                {
                    if (minElement > arr[k])
                    {
                        minElement = arr[k];
                        index = k;
                    }
                }
                if (minElement != arr[j])
                {
                    arr[j] = arr[j]+ arr[index];
                    arr[index] = arr[j] - arr[index];
                    arr[j] = arr[j] - arr[index];
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
