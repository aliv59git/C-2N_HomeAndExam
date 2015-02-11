using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.CombinationsOfSet
{
    class Program
    {
//•	Write a program that reads two numbers N and K and generates all the 
//    combinations of K distinct elements from the set [1..N].

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integer numbers n and k (k < n):");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    
                }
            }



        }
    }
}
