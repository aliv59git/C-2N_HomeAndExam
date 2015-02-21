using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3.StringOperations
{
    class StringOperations
    {
        static string ReverseString(string str)
        {
            StringBuilder result = new StringBuilder(str.Length);
            for (int i = str.Length-1; i >= 0; i--)
            {
                result.Append(str[i]);
            }
            string resultNew = result.ToString().Trim();
            return resultNew;
        }

        static string ExtractCapitalLeters(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString().Trim();
        }
        



        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            result.Append("a");
            result.Append("a");
            result.Append("a");
            result.AppendLine("abcdefgh");
            Console.WriteLine(result.ToString().Trim());
            string res = "1ESR23C4981V723T094Y87120USI3IO9O48OIIU71029348701928374 b990";
            Console.WriteLine(ReverseString(res));
            Console.WriteLine(ReverseString(result.ToString()));
            Console.WriteLine(ExtractCapitalLeters(res));

            string s2 = 53.ToString("F2");
            Console.WriteLine(s2);
            s2 = 53.ToString("P");
            Console.WriteLine(s2);
            s2 = 53.ToString("C");
            Console.WriteLine(s2);
            s2 = 53.ToString("X");
            Console.WriteLine(s2); 
            s2 = 53.ToString("E");
            Console.WriteLine(s2); 
            s2 = 53.ToString("D");
            Console.WriteLine(s2);

            string text1 = string.Format("{0:F2}", 53);
            Console.WriteLine(text1);

            string template = "{0:F3}, {1:P}, {2:E}";
            string text2 = string.Format(template, 53, 45, 78);
            Console.WriteLine(text2);

            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            Console.WriteLine(DateTime.Now);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.WriteLine(DateTime.Now);

            //за да работи в различните култури
            DateTime parsed = DateTime.ParseExact("17.02.15", "dd.mm.yy", CultureInfo.InvariantCulture);
            //даваме му стринга както го искаме, даваме му формата, който описва този начин и инвариантна култура. 
            Console.WriteLine(parsed.Year);
        }
    }
}
