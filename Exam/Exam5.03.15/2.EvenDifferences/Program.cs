using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EvenDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] inputNumbs = new long[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputNumbs[i] = long.Parse(input[i]);
            }
            ulong sumpOfEventsDiff = 0;
            ulong cuttentDifference=0;
            int jump = 0;
            for (int i = 1; i < inputNumbs.Length; i++)
            {
                cuttentDifference = (ulong)Math.Abs(inputNumbs[i] - inputNumbs[i - 1]);
                if (cuttentDifference % 2 == 0)
                {
                    sumpOfEventsDiff += cuttentDifference;
                    jump = 2;
                }
                else if (cuttentDifference % 2 == 1)
                {
                    jump = 1;
                }
                i += jump-1;

            }

            Console.WriteLine(sumpOfEventsDiff);


        }
    }
}
