using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHellow
{
    class Program
    {
//        •	Write a method that asks the user for his name and prints “Hello, <name>”
//•	Write a program to test this method.


        static void PrintHellow()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hellow, {0}!", name);
        }

        static void Main(string[] args)
        {
            PrintHellow();
        }
    }
}
