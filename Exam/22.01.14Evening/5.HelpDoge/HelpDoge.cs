using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class HelpDoge
{
    private static int n, m, fX, fY;
    static void Main(string[] args)
    {
        var matrixRes = Input();

        for (int x = 0; x < matrixRes.GetLength(0); x++)
        {
            for (int y = 0; y < matrixRes.GetLength(1); y++)
			{
                if (x == 0 && y == 0)
                {
                    matrixRes[0, 0] = 1;
                    continue;
                }
                 if (matrixRes[x, y] == -1)
                {
                    matrixRes[x, y] = 0;
                    continue;
                }               if (x == 0)
                {
                    matrixRes[0, y] = matrixRes[0, y - 1];
                    continue;
                }



                if (y == 0)
                {
                    matrixRes[x, 0] = matrixRes[x - 1, 0];
                    continue;
                }

                matrixRes[x, y] = matrixRes[x - 1, y] + matrixRes[x, y - 1];

			}
        }

        Console.WriteLine(matrixRes[fX, fY]);
    }
    private static BigInteger[,] Input()
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        string[] second = Console.ReadLine().Split(' ');
        n = int.Parse(firstLine[0]);
        m = int.Parse(firstLine[1]);
        fX = int.Parse(second[0]);
        fY = int.Parse(second[1]);
        BigInteger[,] matrixRes = new BigInteger[n, m];
        matrixRes[0, 0] = 1;
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            int xCoord = int.Parse(line[0]);
            int yCoord = int.Parse(line[1]);
            matrixRes[xCoord, yCoord] = -1;
        }

        return matrixRes;
    }
}
