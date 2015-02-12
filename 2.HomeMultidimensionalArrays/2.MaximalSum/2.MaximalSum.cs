using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaximalSum
{
    class Program
    {
//•	Write a program that reads a rectangular matrix of size N x M and finds 
//    in it the square 3 x 3 that has maximal sum of its elements.

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter intiger M = ");
            int m = int.Parse(Console.ReadLine());
            int bestRow = 0;
            int bestCol = 0;
            int bestSum = 0;
            int currentSum = 0;
            Console.WriteLine("Please, enter element of matrix, separated by space row by row: ");
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(str[j]);
                }
            }
            for (int row = 0; row < n-2; row++)
            {
                for (int col = 0; col < m-2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if(currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("The maximal sum of submatrix 3 x 3  is: {0} and it's upper left corner is at row = {1} and col = {2}", bestSum, bestRow, bestCol);


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write("{0, 4}", matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
