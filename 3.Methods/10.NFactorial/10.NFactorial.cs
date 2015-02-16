using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.NFactorial
{
    class Program
    {
//•	Write a program to calculate n! for each n in the range [1..100].
        static BigInteger Factorial(int number)
        {
            BigInteger result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static BigInteger[] MultiplayArrayOfDigitsByDigit(BigInteger[] array, int digit)
        {
            BigInteger[] result = new BigInteger[array.Length + 1];

            BigInteger upper = 0;
            for (int i = array.Length-1; i >=0 ; i--)
            {
                result[i+1] = (array[i] * digit + upper) % 10;
                upper = (array[i] * digit + upper) / 10;
            }
            if (upper > 0)
            {
                result[0] = upper;
            }

            return result;
        }

        //with Biginteger the method MultiplayArrayOfDigitsByDigit works as digit is not only digit, but number!
        //That's true, that variable "upper" may be too large and is in BigInteger format;
        static BigInteger[] MultiplayArrayOfDigitsByNumber(BigInteger[] array, int number)
        {
            int counter = 0;
            BigInteger[] res1 = new BigInteger[array.Length + 1];
            BigInteger[] res2 = new BigInteger[array.Length + 1];
            BigInteger[] result = new BigInteger[array.Length + 2];
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (counter == 0)
                {
                    res1 = MultiplayArrayOfDigitsByDigit(array, digit);
                }
                else
                {
                    res2 = MultiplayArrayOfDigitsByDigit(array, digit);
                }
                counter++;
            }

            BigInteger upper = 0;
            result[array.Length + 1] = res1[array.Length];
            for (int i = array.Length; i > 0; i--)
            {
                result[i] = res1[i - 1] + upper + res2[i];
                upper = (res1[i - 1] + upper + res2[i]) / 10;
            }
            if (upper > 0)
            {
                result[0] = upper;
            }

            return result;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number: (up to 10000 digits)");
            string str = Console.ReadLine();
            BigInteger[] arr = new BigInteger[str.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = str[i] - 48;
            }
            Console.WriteLine("Please, enter intiger digit(or two-three digits number): ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine("Number * digit = "+string.Join("", MultiplayArrayOfDigitsByDigit(arr, digit)));
            //Console.WriteLine("Please, enter two digit intiger number: ");
            //int numb = int.Parse(Console.ReadLine());
            //Console.WriteLine(string.Join("", MultiplayArrayOfDigitsByNumber(arr, numb)));
            Console.WriteLine("Please, enter intiger number n < 100: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 11)
            {
                int factorial = 1;
                for (int j = 2; j < n; j++)
                {
                    factorial *= j;
                }
                Console.WriteLine("Factorial {0}! = {1}", n, factorial);
                return;
            }
            string strF = "3628800";
            BigInteger[] arrF = new BigInteger[strF.Length];
            for (int i = 0; i < strF.Length; i++)
            {
                arrF[i] = strF[i] - 48; 
            }
            for (int i = 11; i <= n; i++)
            {
                arrF = MultiplayArrayOfDigitsByDigit(arrF, i);
            }
            Console.WriteLine("Factorial {0}! = {1}", n, string.Join("", arrF));
            //Compare calculations using BigInteger
            Console.WriteLine("With BigInteger: ");
            Console.WriteLine(Factorial(n));
        }
    }
}
