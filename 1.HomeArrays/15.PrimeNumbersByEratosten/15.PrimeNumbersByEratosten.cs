using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PrimeNumbersByEratosten
{
    class Program
    {
        //•	Write a program that finds all prime numbers in the range [1...10 000 000]. 
        //Use the Sieve of Eratosthenesalgorithm.

        static void Main(string[] args)
        {
            List<int> primeByEratosten = new List<int>();
            for (int i = 2; i < 10000000; i++)
            {
                primeByEratosten.Add(i);
            }
            int p=2, multiplyer=1;
            while (p * multiplyer < 10000000)
            {
                while (p * multiplyer < 10000000)
                {
                    multiplyer++;
                    primeByEratosten.Remove(p * multiplyer);
                }
                p++;
                multiplyer = 1;
            }
            //comment printing of set a smoller number i.e. 100000
            for (int j = 0; j < primeByEratosten.Count; j++)
            {
                Console.Write("{0} ", primeByEratosten[j]);
            }
            Console.WriteLine();
        }
    }
}
