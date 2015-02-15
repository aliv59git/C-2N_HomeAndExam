using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FirstLargerThanNeighbours
{
    class Program
    {
        //•	Write a method that returns the index of the first element in array that is larger than its neighbours, 
        //    or -1, if there’s no such element.
        //•	Use the method from the previous exercise.

        static bool LargerThanNeighbours(int[] array, int position)
        {
            bool isLarger = false;
            if (position == 0 || position == array.Length - 1)
            {
                Console.WriteLine("There is not two neighbours!");
            }
            else if (position < 0 || position >= array.Length)
            {
                Console.WriteLine("Position is out of range!");
            }
            else
            {
                if ((array[position] > array[position - 1] && array[position] > array[position + 1]))
                {
                    isLarger = true;
                }
            }
            return isLarger;
        }

        static int FirstLargerThanNeighbours(int[] array)
        {
            int result = -1;
            for (int i = 1; i < array.Length-1; i++)
            {
                if (LargerThanNeighbours(array, i))
                {
                    result = i;
                    break;
                }
            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger numbers, separated by space:");
            string[] str = Console.ReadLine().Split(' ');
            int[] arr = new int[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            if (FirstLargerThanNeighbours(arr) != -1)
            {
                Console.WriteLine("The index of the first element in an array that is larger than its neighbours is {0}.", FirstLargerThanNeighbours(arr));
            }
            else
            {
                Console.WriteLine("There is not such element, that is larger than their neighbours.");
            }
        }
    }
}
