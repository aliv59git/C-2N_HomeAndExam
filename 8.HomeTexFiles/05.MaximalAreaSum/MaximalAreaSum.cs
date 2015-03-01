using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalAreaSum
{
//•	Write a program that reads a text file containing a square matrix of numbers.
//•	Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//o	The first line in the input file contains the size of matrix N.
//o	Each of the next N lines contain N numbers separated by space.
//o	The output should be a single number in a separate text file.

    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\fileInput.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");
        using (strReader)
        {
            int n = int.Parse(strReader.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] temp = strReader.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(temp[j]);
                }
            }
            int bestSum = 0;
            int currentSum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }
            writer.WriteLine(bestSum);
            writer.Close();
        }

        StreamReader strResult = new StreamReader(@"..\..\result.txt");
        Console.WriteLine(strResult.ReadLine());
        strResult.Close();

    }
}
