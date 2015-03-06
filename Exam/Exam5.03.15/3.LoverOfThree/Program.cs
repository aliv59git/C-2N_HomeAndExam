using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LoverOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int r = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            int n = int.Parse(Console.ReadLine());
            string[] directions = new string[n];
            int[] moves = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                directions[i] = temp[0];
                moves[i] = int.Parse(temp[1]);
            }
            int[,] field = new int[r, c];
            for (int i = r-1; i >=0; i--)
            {
                for (int j = 0; j < c; j++)
                {
                    field[i, j] = 3 * (r - 1 - i) + 3 * j;
                }
            }
            ulong sum = 0;
            int currC = 0;
            int currR = r - 1;
            for (int i = 0; i < n; i++)
            {
                string direction = directions[i];
                for (int j = 0; j < moves[i]; j++)
                {

                    if (direction == "RU" || direction =="UR")
                    {
                        sum+=(ulong)field[currR, currC];
                        field[currR, currC] = 0;
                        currR--;
                        currC++;
                        if(currR<0)
                        {
                            currR++;
                            currC--;
                            break;
                        }
                        if (currC > c-1)
                        {
                            currC--;
                            currR++;
                            break;
                        }
                        if (j == moves[i] - 1)
                        {
                            currR++;
                            currC--;
                            break;
                        }
                    }
                    if (direction == "LU"||direction =="UL")
                    {
                        sum += (ulong)field[currR, currC];
                        field[currR, currC] = 0;
                        currR--;
                        currC--;
                        if (currR < 0)
                        {
                            currR++;
                            currC++;
                            break;

                        }
                        if (currC < 0)
                        {
                            currC++;
                            currR++;
                            break;
                        }
                        if (j == moves[i] - 1)
                        {
                            currR++;
                            currC++;
                            break;
                        }
                    }
                    if (direction == "DL" || direction == "LD")
                    {
                        sum += (ulong)field[currR, currC];
                        field[currR, currC] = 0;
                        currR++;
                        currC--;
                        if (currR > r-1)
                        {
                            currR--;
                            currC++;
                            break;
                        }
                        if (currC < 0)
                        {
                            currC++;
                            currR--;
                            break;
                        }
                        if (j == moves[i] - 1)
                        {
                            currR--;
                            currC++;
                            break;
                        }
                    }
                    if (direction == "RD" || direction == "DR")
                    {
                        sum += (ulong)field[currR, currC];
                        field[currR, currC] = 0;
                        currR++;
                        currC++;
                        if (currR > r-1)
                        {
                            currR--;
                            currC--;
                            break;
                        }
                        if (currC >c-1)
                        {
                            currC--;
                            currR--;
                            break;
                        }
                        if (j == moves[i] - 1)
                        {
                            currR--;
                            currC--;
                            break;
                        }
                    }                    

                }

            }
            Console.WriteLine(sum);


        }
    }
}
