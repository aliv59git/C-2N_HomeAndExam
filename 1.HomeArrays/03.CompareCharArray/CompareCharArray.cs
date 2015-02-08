using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareCharArray
{
    class CompareCharArray
    {
        //•	Write a program that compares two char arrays lexicographically (letter by letter).
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter first char array (enter string of chars): ");
            string str = Console.ReadLine();
            char[] chaArr = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                chaArr[i] = str[i];
            }
            Console.WriteLine("Please, enter second char array (enter string of chars): ");
            string str1 = Console.ReadLine();
            char[] chaArr1 = new char[str1.Length];
            bool isEqual = true;
            for (int j = 0; j < str1.Length; j++)
            {
                chaArr1[j] = str1[j];
                if(chaArr1[j] - chaArr[j] !=0)
                {
                    isEqual = false;
                    break;
                }
            }
            Console.WriteLine("Is equal?: {0}", isEqual);


        }
    }
}
