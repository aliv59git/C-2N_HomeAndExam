using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FillTheMatrix
{
    class Program
    {
        //•	Write a program that fills and prints a matrix of size (n, n) as shown below:
        static void Main(string[] args)
        {
            int n = 7;
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i+1+n*j;
                    Console.Write("{0}   ", matrix[i, j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            int[,] matrix1 = new int[n, n];
            int row = 0, col = 0;
            int counter = n * n;
            string direction = "down";
            for (int i = 0; i < counter; i++)
            {
                if (direction == "down" && (row > n - 1))
                {
                    direction = "up";
                    row--;
                    col++;
                }
                else if (direction == "up" && (row < 0))
                {
                    direction = "down";
                    row++;
                    col++;
                }
                matrix1[row, col] = i + 1;
                if (direction == "down")
                {
                    row++;
                }
                else if (direction == "up")
                {
                    row--;
                }
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            int[,] matrix2 = new int[n, n];
            int row1 = n-1, col1 = 0;
            int counter1 = n * n;
            string direction1 = "downRight";
            int countDown = 0;
            int countRight = 0;
            for (int k = 0; k < counter1; k++)
            {
                //living matrix on down
                if((direction1 == "downRight") && (row1 > n - 1))
                {
                    row1 -= (countDown+1);
                    col1 -= countRight;
                    if (row1 < 0)
                    {
                        row1++;
                        col1++;
                        countRight = 0;
                        countDown = 0;
                    }
                    countRight = 0;
                    countDown = 0;
                }

                //living matrix on right
                if ((direction1 == "downRight") && (col1 > n - 1))
                {
                    row1 -= (countDown+1);
                    col1 -= countRight;
                    if (row1 < 0)
                    {
                        row1++;
                        col1++;
                        countRight = 0;
                        countDown = 0;
                    }
                    countRight = 0;
                    countDown = 0;
                }

                matrix2[row1, col1] = k + 1;
                if (direction1 == "downRight") 
                {
                    row1++;
                    col1++;
                    countDown++;
                    countRight++;
 
                }

            }
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            int[,] matrix3 = new int[n, n];
            int row3 = 0, col3 = 0;
            int counter3 = n * n;
            string direction3 = "down";
            for (int m = 0; m < counter3; m++)
            {
                if (direction3 == "down" && ((row3 > n - 1) || (matrix3[row3, col3] != 0)))
                {
                    direction3 = "right";
                    row3--;
                    col3++;
                }
                else if (direction3 == "right" && ((col3 > n - 1) || (matrix3[row3, col3] != 0)))
                {
                    direction3 = "up";
                    row3--;
                    col3--;
                }
                else if (direction3 == "up" && ((row3 < 0) || (matrix3[row3, col3] != 0)))
                {
                    direction3 = "left";
                    row3++;
                    col3--;
                }
                else if (direction3 == "left" && ((col3 < 0) || (matrix3[row3, col3] != 0)))
                {
                    direction3 = "down";
                    row3++;
                    col3++;
                }
                matrix3[row3, col3] = m + 1;
                if (direction3 == "down")
                {
                    row3++;
                }
                else if (direction3 == "right")
                {
                    col3++;
                }
                else if (direction3 == "up")
                {
                    row3--;
                }
                else if (direction3 == "left")
                {
                    col3--;
                }
            }
            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix3[i, j]);
                }
                Console.WriteLine();
            }



        }
    }
}
