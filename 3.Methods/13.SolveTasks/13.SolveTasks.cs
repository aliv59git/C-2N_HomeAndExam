using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SolveTasks
{
    class Program
    {
//•	Write a program that can solve these tasks:
//o	Reverses the digits of a number
//o	Calculates the average of a sequence of integers
//o	Solves a linear equation a * x + b = 0
//•	Create appropriate methods.
//•	Provide a simple text-based menu for the user to choose which task to solve.
//•	Validate the input data:
//o	The decimal number should be non-negative
//o	The sequence should not be empty
//o	a should not be equal to 0

        static string ReverseTheDigitsOfANumber(string number)
        {
            if (!ValidateInputData(number)) 
            {
                throw new ArgumentException("Invalid data! The number will be not negative!");
            }
            return string.Join("", number.ToCharArray().Reverse());
        }

        static double AverageOfSequenceOfIntigers(long[] array)
        {
            if (!ValidateInputData(array))
            {
                throw new ArgumentException("Invalid Data! The sequence will be not empty");
            }
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }
        static double SolvesLinearEquation(double a, double b) //Linear equation: a*x + b = 0
        {
            if (!ValidateInputData(a))
            {
                throw new ArgumentException("Invalid Data! a must be != 0");
            }
            return -b / a;
        }

        static bool ValidateInputData(string number)
        {
            bool isValid = true;
            if (number.Substring(0, 1) == "-")
            {
                isValid = false;
            }
            return isValid;
        }
        static bool ValidateInputData(long[] array)
        {
            bool isValid = true;
            if (array.Length <= 0)
            {
                isValid = false;
            }
            return isValid;
        }
        static bool ValidateInputData(double a)
        {
            bool isValid = true;
            if (a == 0)
            {
                isValid = false;
            }
            return isValid;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, choise task to solve: \n1 - Reverse the digits of a number; \n2 - Calculates the average of a sequence of integers; \n3 - Solves a linear equation a * x + b = 0");
            int numb = int.Parse(Console.ReadLine());
            switch (numb)
            {
                case 1: Console.WriteLine("Please, enter ulong number: (up to 10000 digits)");
                    string number = Console.ReadLine();
                    Console.WriteLine(ReverseTheDigitsOfANumber(number)); break;
                case 2: Console.WriteLine("Please, enter intiger numbers, separated by comma and space: ");
                    string[] str = Console.ReadLine().Split(',');
                    long[] arr = new long[str.Length];
                    for (int i = 0; i < str.Length; i++)
                    {
                        arr[i] = long.Parse(str[i]);
                    }
                    Console.WriteLine("Average = {0}", AverageOfSequenceOfIntigers(arr)); break;
                case 3: Console.WriteLine("Please, enter a = )");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please, enter b = )"); 
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Solves linear equation -> x = {0}", SolvesLinearEquation(a, b));
                    break;
                default: Console.WriteLine("Invalid choice!"); break;

            }



        }
    }
}
