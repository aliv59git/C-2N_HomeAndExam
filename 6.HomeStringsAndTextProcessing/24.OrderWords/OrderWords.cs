using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OrderWords
{
  //Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
    
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter words, separated by space: ");
        string[] words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        Console.WriteLine(string.Join(" ", words));
    }
}
