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

            numbers.Sort();
            string res = string.Join("", numbers);
            if (res[0] == '0')
            {
                res = res.Substring(1);
            }
            Console.WriteLine(res.Distinct().ToArray());







            bool isGreater = false;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < res.Length - 1; i++)
            {
                int tempInd = res.IndexOf(res[i], i + 1);
                if (tempInd != -1)
                {
                    for (int j = i + 1; j < tempInd; j++)
                    {
                        if (res[i] > res[j])
                        {
                            isGreater = true;
                        }
                    }
                    if (isGreater == true)
                    {
                        res = res.Substring(0, i) + "*" + res.Substring(i + 1);
                    }
                    else
                    {
                        if (tempInd + 1 <= res.Length - 1)
                        {
                            res = res.Substring(0, tempInd) + "*" + res.Substring(tempInd + 1);
                        }
                        else
                        {
                            res = res.Substring(0, tempInd) + "*";
                        }
                    }
                }
                tempInd = -1;
                isGreater = false;
            }

            foreach (var item in res)
            {
                if (item != '*')
                {
                    sb.Append(item);
                }
            }
            Console.WriteLine(sb.ToString());

            //Console.WriteLine(string.Join("", numbers.Distinct().ToArray()));

        }
    }
}
