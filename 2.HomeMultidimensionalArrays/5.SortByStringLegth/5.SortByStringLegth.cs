using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortByStringLegth
{
    class Program
    {
        //•	You are given an array of strings. Write a method that sorts the array by the length 
        //    of its elements (the number of characters composing them).

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter strins, separated by space");
            string[] arrStr = Console.ReadLine().Split(' ');
            Array.Sort(arrStr, new StrComparer());
            foreach (string str in arrStr)
            {
                Console.Write(str + "  ");
            }
            Console.WriteLine();
        }

        private class StrComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                int xLength = x.Length;
                int yLength = y.Length;
                return xLength.CompareTo(yLength);
            }
        }
    }
}
