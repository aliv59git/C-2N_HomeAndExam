using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargerThanNeighbours
{
    class Program
    {
        //•	Write a method that checks if the element at given position in given array of integers is larger 
        //    than its two neighbours (when such exist).

        static bool LargerThanNeighbours(int[] array, int position)
        {
            bool isLarger = false;
            if (position == 0 || position == array.Length - 1)
            {
                Console.WriteLine("There is not two neighbours!");
            }
            else if(position <0 || position >= array.Length){
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


        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger numbers, separated by comma and space:");
            string[] str = Console.ReadLine().Split(',');
            int[] arr = new int[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(str[i]);
            }
            Console.Write("Please, enter intiger position p = ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the element at position {0} larger than its neighbours? ->  {1}", p, LargerThanNeighbours(arr, p));
        }
    }
}
