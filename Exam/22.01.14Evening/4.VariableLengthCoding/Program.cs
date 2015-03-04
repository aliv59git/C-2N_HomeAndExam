using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.VariableLengthCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initial = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder encoded = new StringBuilder();
            for (int i = 0; i < initial.Length; i++)
            {
                encoded.Append(Convert.ToString(int.Parse(initial[i]), 2).PadLeft(8, '0'));
            }
            //Console.WriteLine(encoded);
            int n = int.Parse(Console.ReadLine());       //n = numbOfLineInCodeTable
            char[] codeTable = new char[n + 1]; 
            string line;
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                codeTable[int.Parse(line.Substring(1))] = line[0];
            }
            //Console.WriteLine(string.Join(" ", codeTable));

            StringBuilder decoded = new StringBuilder();
            int ones = 0;
            string toDecoding = encoded.ToString();
            for (int j = 0; j < encoded.ToString().Length; j++)
            {
                char ch = toDecoding[j];
                if (ch == '1')
                {
                    ones++;
                }
                else if (ch == '0')
                {
                    decoded.Append(codeTable[ones]);
                    ones = 0;
                }
            }
            Console.WriteLine(decoded);
        }
    }
}
