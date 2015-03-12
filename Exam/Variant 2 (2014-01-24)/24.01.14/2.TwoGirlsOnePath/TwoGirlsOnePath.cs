using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class TwoGirlsOnePath
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int n = input.Length;
        BigInteger flowersM = 0;
        BigInteger flowersD = 0;
        BigInteger[] inputNumb = new BigInteger[n];
        for (int i = 0; i < n; i++)
        {
            inputNumb[i] = BigInteger.Parse(input[i]);
        }
        int currentIndexM = 1;
        int currentIndexD = n;
        string firstLine = "";
        while (inputNumb[currentIndexM] != 0 || inputNumb[currentIndexD] != 0)
        {
            flowersM += inputNumb[currentIndexM];
            inputNumb[currentIndexM] = 0;
            flowersD += inputNumb[currentIndexD];
            inputNumb[currentIndexD] = 0;
            currentIndexM = (int)(((BigInteger)currentIndexM + inputNumb[currentIndexM]) % (BigInteger)n);
            BigInteger temp = n - ((BigInteger)currentIndexD - inputNumb[currentIndexD] % (BigInteger)n);
            if (temp < 0)
            {
                temp = -temp;
            }
            currentIndexD = (int)(temp);


            if ((inputNumb[currentIndexM] != 0) && (inputNumb[currentIndexD] == 0))
            {
                firstLine = "Molly";
            }
            else if ((inputNumb[currentIndexM] == 0) && (inputNumb[currentIndexD] != 0))
            {
                firstLine = "Dolly";
            }
            else if ((inputNumb[currentIndexM] == 0) && (inputNumb[currentIndexD] == 0))
            {
                firstLine = "Drow";
            }
        }

        Console.WriteLine(firstLine);
        Console.WriteLine(flowersM+" "+flowersD);
    }
}
