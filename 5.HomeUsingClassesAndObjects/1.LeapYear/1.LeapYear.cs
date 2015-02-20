using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //•	Write a program that reads a year from the console and checks whether it is a leap one.
    //•	Use System.DateTime.


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter year: ");
        int enteredYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Is {0} a leap year?  {1}", enteredYear, DateTime.IsLeapYear(enteredYear));
    }
}
