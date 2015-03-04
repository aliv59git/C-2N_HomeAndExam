using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Patterns
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(temp[j]);
            }
        }

        bool success = false;
        long bestSum = 0;
        long currentSum = 0;
        for (int i = 0; i < matrix.GetLength(0)-2; i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-4; j++)
            {
                if ((matrix[i, j+1] - matrix[i, j]==1) && 
                    (matrix[i, j+2]- matrix[i, j+1]==1) && 
                    (matrix[i+1, j+2]-matrix[i, j + 2]==1) && 
                    (matrix[i+2, j + 2]- matrix[i +1, j + 2]==1 ) && 
                    (matrix[i + 2, j + 3]- matrix[i + 2, j + 2]==1 ) && 
                    (matrix[i + 2, j + 4]- matrix[i + 2, j + 3]==1))
                {
                    currentSum += 7 * matrix[i, j] + 21;
                    if (bestSum < currentSum)
                    {
                        bestSum = currentSum;
                    }
                    success = true;
                    currentSum = 0;
                }

            }
        }

        if (success==true)
        {
            Console.WriteLine("YES " + bestSum);
        }
        else if (success == false)
        {
            for (int k = 0; k < n; k++)
            {
                bestSum += matrix[k, k];
            }
            Console.WriteLine("NO "+ bestSum);
        }
    }
}
