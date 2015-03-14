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
            List<string> numbers = new List<string>();
            int indexBefore;
            int indexAfter;
            string neRes = string.Empty;
            for (int i = 0; i < n; i++)
			{
                input[i] = Console.ReadLine();
                indexBefore = input[i].IndexOf("before");
                indexAfter = input[i].IndexOf("after");
                if (indexBefore > -1)
                {
                    string str = input[i].Substring(0, 1) + input[i].Substring(input[i].Length - 1, 1);
                    //int numb = int.Parse(str);
                    bool contains = false;
                    foreach (var numbE in numbers)
                    {
                        if (str == numbE)
                        {
                            contains = true;
                        }
                    }
                    if (contains == false)
                    {
                        numbers.Add(str);
                    }
                }
                if (indexAfter > -1)
                {
                    string str1 = input[i].Substring(input[i].Length - 1, 1) + input[i].Substring(0, 1);
                    //int numb = int.Parse(str1);
                    bool contains = false;
                    foreach (var numbE in numbers)
                    {
                        if (str1 == numbE)
                        {
                            contains = true;
                        }
                    }
                    if (contains == false)
                    {
                        numbers.Add(str1);
                    }
                }                    
			}
            Console.WriteLine(string.Join("", numbers));
            numbers.Sort();
            List<char> result = string.Join("", numbers).ToList();
            if (result[0] == '0')
            {
                result.Remove('0');
            }
            for (int i = 0; i < result.Count-1; i++)
            {
                char ch = result[i];
                for (int j = i+1; j < result.Count; j++)
                {
                    if (result[j] == ch)
                    {
                        bool isRemoved = false;
                        for (int t = i+1; t <= j; t++)
                        {
                            if (result[t] > ch)
                            {
                                result.RemoveAt(j);
                                result.Insert(j, '*');
                                isRemoved = true;
                            }
                        }
                        if (isRemoved == false)
                        {
                            result.RemoveAt(i);
                            result.Insert(i, '*');
                        }
                        isRemoved = false;
                    }
                }
            }
            Console.WriteLine(string.Join("", result));

            result.RemoveAll(ch => ch == '*'); 
            Console.WriteLine(string.Join("", result));
        }
    }
}
