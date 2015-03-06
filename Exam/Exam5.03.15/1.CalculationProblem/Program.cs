using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CalculationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            long sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string temp = input[i];
                long tempDeci = 0;
                long multiplayer = 1;
                for (int j = temp.Length-1; j >=0; j--)
                {
                    tempDeci += (temp[j]-97) * multiplayer;
                    multiplayer *= 23;
                }
                //Console.WriteLine(tempDeci);
                sum += tempDeci;

            }
            long number = sum;
            StringBuilder sb = new StringBuilder();
            while (number > 0)
            {
                int temp = (int)(number % 23);
                char tmp = (char)(temp + 97);
                sb.Append(tmp);
                number /= 23;

            }
            string result = string.Join("", sb.ToString().Reverse());
            Console.WriteLine(result+" = "+sum);

            //Console.WriteLine(sum);
        }
    }
}
