using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1.IndexOfLetters
{
    class Program
    {
        //other solution of problem
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a word: ");
            string str = Console.ReadLine();
            for (int k = 0; k < str.Length; k++)
            {
                if ((int)str[k] > 64 && (int)str[k] < 91) 
                { 
                    Console.Write((int)str[k]-65 + " ");
                }
                else
                {
                    Console.Write((int)str[k] - 97 + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
