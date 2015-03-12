using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1.NewBadCat
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
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                indexBefore = temp.IndexOf("before");
                indexAfter = temp.IndexOf("after");
                if (indexBefore > -1)
                {
                    string str = temp.Substring(0, 1) + temp.Substring(temp.Length - 1, 1);
                    //int numb = int.Parse(str);
                    bool contains = false;
                    foreach (var numbE in input)
                    {
                        if (str == numbE)
                        {
                            contains = true;
                        }
                    }
                    if (contains == false)
                    {
                        input[i] = str;
                    }
                }
                if (indexAfter > -1)
                {
                    string str = temp.Substring(temp.Length - 1, 1) + temp.Substring(0, 1);
                    //int numb = int.Parse(str);
                    bool contains = false;
                    foreach (var numbE in input)
                    {
                        if (str == numbE)
                        {
                            contains = true;
                        }
                    }
                    if (contains == false)
                    {
                        input[i] = str;
                    }
                }
            }
            Array.Sort(input);
            List<string> cloneInput = new List<string>();
            foreach (var item in input)
            {
                if (item != null)
                {
                    cloneInput.Add(item);
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < cloneInput.Count - 1; i++)
            {
                bool isFirst = false;
                bool isSecond = false;
                for (int j = i + 1; j < cloneInput.Count; j++)
                {
                    if ((cloneInput[i][0] == cloneInput[j][0]) || (cloneInput[i][0] == cloneInput[j][1]))
                    {
                        isFirst = true;
                    }

                    if ((cloneInput[i][1] == cloneInput[j][0]) || (cloneInput[i][1] == cloneInput[j][1]))
                    {
                        isSecond = true;
                    }
                }
                if (isFirst == true)
                {
                    sb.Append(cloneInput[i][1]);
                }
                else if (isSecond == true)
                {
                    sb.Append(cloneInput[i][0]);
                }
                else if ((isFirst == false) && (isSecond == false))
                {
                    sb.Append(cloneInput[i]);
                }

            }
            sb.Append(cloneInput[cloneInput.Count - 1]);
            Console.WriteLine(string.Join("", sb.ToString()));
        
        
        }
    }
}
