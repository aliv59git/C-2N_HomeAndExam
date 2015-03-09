using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MagicWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new List<string>();
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                var word = words[i];
                var nextIndex = word.Length % (n + 1);

                words[i] = null;
                words.Insert(nextIndex, word);
                words.Remove(null);
            }
            //Print Първо намира максималната дума от колекцията/дължината на най-голямата дума:
            var maxLength = 0;
            foreach (var item in words)
            {
                maxLength = Math.Max(maxLength, item.Length);
            }
            //var maxLength = words.Max(x => x.Length);

            var result = new StringBuilder();
            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (word.Length > i)
                    {
                        result.Append(word[i]);
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
