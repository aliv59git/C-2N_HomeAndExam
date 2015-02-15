using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _08.NumberAsArray
{
    class Program
    {
        //•	Write a method that adds two positive integer numbers represented as arrays of digits (each array element 
        //    arr[i]contains a digit; the last digit is kept in arr[0]).
        //•	Each of the numbers that will be added could have up to 10 000 digits.

        static BigInteger SumOfNumbers(BigInteger numb1, BigInteger numb2)
        {
            return numb1 + numb2;
        }

        static BigInteger AddNumbersAsArray(BigInteger numb1, BigInteger numb2)
        {
            if (numb1 > numb2)
            {
                BigInteger tmp = numb1;
                numb1 = numb2;
                numb2 = tmp;
            }
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            while (numb1 > 0)
            {
                int digit = (int)(numb1 % 10);
                list1.Add(digit);
                numb1 /= 10;
            }
            while (numb2 > 0)
            {
                int digit = (int)(numb2 % 10);
                list2.Add(digit);
                numb2 /= 10;
            }
            //numb1 and numb2 represented as arrays of digits list1 and list2
            //(each array element arr[i]contains a digit; the last digit is kept in arr[0]).

            int counter = list1.Count;
            List<int> resultOfAdding = new List<int>();
            int upper = 0;
            for (int i = 0; i < counter; i++)
            {
                int temp = list1[i] + list2[i] + upper;
                if (temp > 9)
                {
                    resultOfAdding.Add(temp % 10);
                    upper = 1;
                }
                else
                {
                    resultOfAdding.Add(temp);
                    upper = 0;
                }
            }
            for (int j = counter; j < list2.Count; j++)
            {
                int temp1 = list2[j] + upper;
                if (temp1 > 9)
                {
                    resultOfAdding.Add(temp1 % 10);
                    upper = 1;
                }
                else
                {
                    resultOfAdding.Add(temp1);
                    upper = 0;
                }
            }
            resultOfAdding.Reverse();
            BigInteger result = BigInteger.Parse(string.Join("", resultOfAdding));
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter first positive intiger number: (up to 10000 digits)");
            BigInteger numb1 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter second positive intiger number: (up to 10000 digits)");
            BigInteger numb2 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Result using integrated in .Net instrument BigInteger");
            BigInteger result = SumOfNumbers(numb1, numb2);
            Console.WriteLine(result);
            //using AddNumbersAsArray() method by requirements of an Item.
            Console.WriteLine();
            Console.WriteLine("Using AddNumbersAsArray() method by requirements of an Item.");
            BigInteger result2 = AddNumbersAsArray(numb1, numb2);
            Console.WriteLine(result2);
        }
    }
}
