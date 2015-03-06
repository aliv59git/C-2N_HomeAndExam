using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BadCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = new string[n];
            List<int> numbers = new List<int>();
            int indexBefore;
            int indexAfter;
            for (int i = 0; i < n; i++)
			{
                input[i] = Console.ReadLine();
                indexBefore = input[i].IndexOf("before");
                indexAfter = input[i].IndexOf("after");
                if (indexBefore > -1)
                {
                    string str = input[i].Substring(0, 1) + input[i].Substring(input[i].Length - 1, 1);
                    int numb = int.Parse(str);
                    bool contains = false;
                    foreach (var numbE in numbers)
                    {
                        if (numb == numbE)
                        {
                            contains = true;
                        }
                    }
                    if (contains == false)
                    {
                        numbers.Add(numb);
                    }
                }
                if (indexAfter > -1)
                {
                    string str = input[i].Substring(input[i].Length - 1, 1) + input[i].Substring(0, 1);
                    int numb = int.Parse(str);
                    bool contains = false;
                    foreach (var numbE in numbers)
                    {
                        if (numb == numbE)
                        {
                            contains = true;
                        }
                    }
                    if (contains == false)
                    {
                        numbers.Add(numb);
                    }
                }                    
			}


            numbers.Sort();
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    numbers.Remove(i);
                }
            }

            string result = string.Join("", numbers);
            Console.WriteLine(result.Distinct().ToArray());

        }
    }
}
