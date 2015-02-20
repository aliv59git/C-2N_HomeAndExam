using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //•	Write a program that generates and prints to the console 10 random values in the range [100, 200].


    static void Main(string[] args)
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.Write(rnd.Next(100, 201)+"  ");
        }
        Console.WriteLine();
    }
}
