using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MatrixClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("For First matrix: Numbers of rows N1 =  ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Numbers of colums M1 = ");
            int m1 = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[n1, m1];
            Console.WriteLine("Please, enter intiger numbers of first matrix, separated by space (row by row)");
            for (int i = 0; i < n1; i++)
            {
                string[] str1 = Console.ReadLine().Split(' ');
                for (int j = 0; j < str1.Length; j++)
                {
                    matrix1[i, j] = int.Parse(str1[i]);
                }
            }

            Console.Write("For second matrix: Numbers of rows N2 =  ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Numbers of colums M2 = ");
            int m2 = int.Parse(Console.ReadLine());
            int[,] matrix2 = new int[n2, m2];
            Console.WriteLine("Please, enter intiger numbers of first matrix, separated by space (row by row)");
            for (int i = 0; i < n2; i++)
            {
                string[] str2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < str2.Length; j++)
                {
                    matrix1[i, j] = int.Parse(str2[i]);
                }
            }

            

        }
    }

    public class Matrix : IEnumerable<int> 
    {
        public int[,] Adding(int[,] matr1, int[,] matr2)
        {
            int[,] result = new int[matr1.GetLength(0), matr1.GetLength(1)];
            if (matr1.GetLength(0) == matr2.GetLength(0) && matr1.GetLength(1) == matr2.GetLength(1))
            {
                for (int i = 0; i < matr1.GetLength(0); i++)
                {
                    for (int j = 0; j < matr2.GetLength(1); j++)
                    {
                        result[i, j] = matr1[i, j] + matr2[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < matr1.GetLength(0); i++)
                {
                    for (int j = 0; j < matr2.GetLength(1); j++)
                    {
                        result[i, j] = -1;
                    }
                }
            }

            return result;
        }
        public int[,] Subtract(int[,] matr1, int[,] matr2)
        {
            int[,] result = new int[matr1.GetLength(0), matr1.GetLength(1)];
            if (matr1.GetLength(0) == matr2.GetLength(0) && matr1.GetLength(1) == matr2.GetLength(1))
            {
                for (int i = 0; i < matr1.GetLength(0); i++)
                {
                    for (int j = 0; j < matr2.GetLength(1); j++)
                    {
                        result[i, j] = matr1[i, j] - matr2[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < matr1.GetLength(0); i++)
                {
                    for (int j = 0; j < matr2.GetLength(1); j++)
                    {
                        result[i, j] = -1;
                    }
                }
            }
            return result;
        }

        public int[,] Multiply(int[,] matr1, int[,] matr2)
        {
            int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
            if (matr1.GetLength(0) == matr2.GetLength(1) && matr1.GetLength(1) == matr2.GetLength(0))
            {
                for (int i = 0; i < matr1.GetLength(0); i++)
                {
                    for (int j = 0; j < matr2.GetLength(1); j++)
                    {
                        for (int k = 0; k < matr1.GetLength(1); k++)
                        {
                            result[i, j] += matr1[i, k] * matr2[k, j];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < matr1.GetLength(0); i++)
                {
                    for (int j = 0; j < matr2.GetLength(1); j++)
                    {
                        result[i, j] = -1;
                    }
                }
            }
            return result;
        }

        public int[,] IndexerForAscending(int[,] matr1)
        {
            int[,] result = new int[matr1.GetLength(0), matr1.GetLength(1)];
            //for (int i = 0; i < matr1.GetLength(0); i++)
            //{
            //    matr1.GetLenght(0) = i;
            //}



            return result;
        }

        public string[] ToString(int[,] matr1)
        {
            string[] result = new string[matr1.GetLength(0)];
            for (int i = 0; i < matr1.GetLength(0); i++)
            {
                string[] str = new string[matr1.GetLength(1)];
                for (int j = 0; j < matr1.GetLength(1); j++)
                {
                    str[j] = matr1[i, j].ToString();
                }
                result[i] = string.Join("  ", str);
            }
            return result;
        }

        public int CompareTo(int[,] matr1, int[,] matr2)
        {
            if(!((matr1.GetLength(0)==matr2.GetLength(0)) & (matr1.GetLength(1)==matr2.GetLength(1))))
            {
                return -1;
            }
            for (int i = 0; i < matr2.GetLength(0); i++)
            {
                for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    if (matr1[i, j] != matr2[i, j])
                    {
                        return -1;
                    }
                }
            }
            return 1;
        }

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}  ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}
