using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class BunnyFactory
{
    static void Main(string[] args)
    {
        List<int> input = new List<int>();
        string str = Console.ReadLine();
        while (str != "END")
        {

            int temp;
            int.TryParse(str, out temp);
            input.Add(temp);
            str = Console.ReadLine();
        }
        //input.ToArray();

        int count = 0;

        while (true)
        {
            int workingCages = 0;
            for (int t = 0; t <= count; t++)
            {
                workingCages += input[t];
            }

            if (workingCages <= input.Count - (count + 1))
            {
                StringBuilder sb = new StringBuilder();
                BigInteger sum = 0;
                BigInteger product = 1;
                for (int i = count + 1; i < workingCages+count+1; i++)
                {
                    sum += input[i];
                    product *= input[i];
                }
                sb.Append(sum);
                sb.Append(product);
                foreach (var digit in sb.ToString())
                {
                    if (digit == '0' || digit == '1')
                    {
                        sb.Remove(sb.ToString().IndexOf(digit), 1);
                    }
                }

                for (int j = workingCages + count+1; j < input.Count; j++)
                {
                    sb.Append(input[j].ToString());
                }

                input.RemoveRange(0, input.Count);
                string tmp = sb.ToString();
                for (int m = 0; m < tmp.Length; m++)
                {
                    input.Add(tmp[m] - 48);
                }
                count++;
            }
            else
            {
                Console.WriteLine(string.Join(" ", input));
                break;
            }
        }
    }
}
