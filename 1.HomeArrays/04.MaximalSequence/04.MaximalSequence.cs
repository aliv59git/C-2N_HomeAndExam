using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaximalSequence
{
    class Program
    {
        //•	Write a program that finds the maximal sequence of equal elements in an array.
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter elements of an array, separated by space: ");
            string[] str = Console.ReadLine().Split(' ');
            int currnetSequence = 1;
            int bestSequence = 0;
            string initialElement = str[0];
            string initial = string.Empty;
            string firstElement = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                string currentEl = str[i];
                if (currentEl == firstElement)
                {
                    currnetSequence++;
                    firstElement = currentEl;
                    if (bestSequence < currnetSequence)
                    {
                        bestSequence = currnetSequence;
                        initial = initialElement;
                    }
                }
                else
                {
                    firstElement = currentEl;
                    initialElement = currentEl;
                    currnetSequence = 1;
                }
            }
            for (int j = 0; j < bestSequence; j++)
            {
                Console.Write("{0} ", initial);
            }
            Console.WriteLine();
        }
    }
}
