using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.VariationsOfSet
{
    class Program
    {
//•	Write a program that reads two numbers N and K and generates all the variations 
//    of K elements from the set [1..N].

        static int n, k, i;
        static int[] arr; 

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter two integer numbers n and k (k < n):");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            arr = new int[k];
            NestedLoops(0);
        }

        static void NestedLoops(int currentNumb)
        {
            if (currentNumb == k)
            {
                Console.Write("{ ");
                for (int i = 0; i < k; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.Write(" }");
                Console.WriteLine();
                return;
            }
            for (int j = 1; j <=n ; j++)
			{
                arr[currentNumb] = j;
                NestedLoops(currentNumb + 1);
			}
        }
    }
}
