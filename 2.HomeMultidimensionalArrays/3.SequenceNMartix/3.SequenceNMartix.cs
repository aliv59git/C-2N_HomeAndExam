using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SequenceNMartix
{
    class Program
    {
//        •	We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//            as sets of several neighbour elements located on the same line, column or diagonal.
//•	Write a program that finds the longest sequence of equal strings in the matrix.


        static void Main(string[] args)
        {
            Console.Write("Number of rows N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Number of cols M = ");
            int m = int.Parse(Console.ReadLine());
            string[,] strMatrix = new string[n, m];
            Console.WriteLine("Please, enter strings n matrix, separated by space (rows by rows)");
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    strMatrix[i, j] = str.Split(' ')[j];
                }
            }
            int bestCount = 0;
            string bestStr = String.Empty;
            int bestRow = -1;
            int bestCol = -1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    //by 1 row
                    int count = 1;
                    int columns = col++;
                    while (columns < m)
                    {
                        bool isEqual = CompareStrings(strMatrix[row, col], strMatrix[row, columns]);
                        if (isEqual)
                        {
                            count++;
                            columns++;
                        }
                        else
                        {
                            if (count > bestCount)
                            {
                                bestCount = count;
                                bestStr = strMatrix[row, col];
                                bestRow = row;
                                bestCol = col;
                            }
                            break;
                        }
                    }
                    //by column
                    int countRow = 1;
                    int rows = n;
                    if (row < n - 1)
                    {
                        rows = row++;
                    } 
                    while (rows < n)
                    {
                        bool isEqual = CompareStrings(strMatrix[row, col], strMatrix[rows, col]);
                        if (isEqual)
                        {
                            countRow++;
                            rows++;
                        }
                        else
                        {
                            if (countRow > bestCount)
                            {
                                bestCount = countRow;
                                bestStr = strMatrix[row, col];
                                bestRow = row;
                                bestCol = col;
                            }
                            break;
                        }
                    }
                    //by diagonal
                    int countDiag = 1;
                    int rowD = n;
                    int colD = m;
                    if ((row < n - 1) && (col < m - 1))
                    {
                        rowD = row++;
                        colD = col++;
                    }

                    while ((rowD < n) && (colD < m))
                    {
                        bool isEqual = CompareStrings(strMatrix[row, col], strMatrix[rowD, colD]);
                        if (isEqual)
                        {
                            countDiag++;
                            rowD++;
                            colD++;
                        }
                        else
                        {
                            if (countDiag > bestCount)
                            {
                                bestCount = countDiag;
                                bestStr = strMatrix[row, col];
                                bestRow = row;
                                bestCol = col;
                            }
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Initial matrix printing");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}  ", strMatrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Result");
            for (int k = 0; k < bestCount; k++)
            {
                Console.Write("{0}  ", bestStr);
            }
            Console.WriteLine("Best row: {0}, best col: {1}", bestRow, bestCol);

        }

        static bool CompareStrings(string str1, string str2)
        {
            bool isEqual = true;
            if (str1.Length != str2.Length) 
            {
                isEqual = false;
                return isEqual;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        isEqual = false;
                        return isEqual;
                    }
                }
            }
            return isEqual;
        }
    }
}
