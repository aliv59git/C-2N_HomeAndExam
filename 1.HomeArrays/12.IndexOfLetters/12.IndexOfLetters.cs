using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.IndexOfLetters
{
    class Program
    {
        //•	Write a program that creates an array containing all letters from the alphabet (A-Z).
        //•	Read a word from the console and print the index of each of its letters in the array.

        static int BinarySearch(int[] arr, int bestNumber)
        {
            int low = 0;
            int high = arr.Length - 1;
            int midpoint = 0;

            while (low <= high)
            {
                midpoint = low + (high - low) / 2;
                if (bestNumber == arr[midpoint])
                {
                    return midpoint;
                }
                else if (bestNumber < arr[midpoint])
                {
                    high = midpoint - 1;
                }
                else
                {
                    low = midpoint + 1;
                }
            }
            // if item was not found
            return -1;
        }

        static void Main(string[] args)
        {
            char[] alphabetCap = new char[26];
            int[] alphabetCapital = new int[26]; 
            char[] alphabetLow = new char[26];
            int[] alphabetLower = new int[26]; 

            for (int i = 0; i < 26; i++)
            {
                alphabetCap[i] = (char)(65 + i);
                alphabetCapital[i] = 65 + i;
            }
            for (int j = 0; j < 26; j++)
            {
                alphabetLow[j] = (char)(97 + j);
                alphabetLower[j] = 97 + j;
            }
            //Console.WriteLine(string.Join(" ", alphabetCap));
            //Console.WriteLine(string.Join(" ", alphabetLow));
            Console.WriteLine("Please, enter a word: ");
            string str = Console.ReadLine();
            for (int k = 0; k < str.Length; k++)
            {
                int numb = BinarySearch(alphabetCapital, (int)str[k]);
                Console.Write(numb + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 3*str.Length));
            for (int t = 0; t < str.Length; t++)
            {
                int numb = BinarySearch(alphabetLower, (int)str[t]);
                Console.Write(numb + " ");
            }
            Console.WriteLine();

        }
    }
}
