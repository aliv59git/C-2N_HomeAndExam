using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class Program
    {
        //•	Write a program that reads two integer arrays from the console and compares them element by element.
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter numbers for first array separated with space:");
            string str1 = Console.ReadLine();
            string[] str = str1.Split(' ');
            int[] arr1 = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                arr1[i] = int.Parse(str[i]);
            }

            Console.WriteLine("Please, enter numbers for second array separated with space:");
            string str2 = Console.ReadLine();
            string[] stri = str2.Split(' ');
            int[] arr2 = new int[stri.Length];
            for (int j   = 0; j < stri.Length; j++)
            {
                arr2[j] = int.Parse(stri[j]);
            }
            bool isEqual = true;
            if (arr1.Length != arr2.Length)
            {
                isEqual = false;
            }
            for (int k = 0; k < arr1.Length; k++)
            {
                if (arr1[k] != arr2[k])
                {
                    isEqual = false;
                    break;
                }
            }
            Console.WriteLine("Is Equal? {0}", isEqual);




        }

        public static int i { get; set; }
    }
}
