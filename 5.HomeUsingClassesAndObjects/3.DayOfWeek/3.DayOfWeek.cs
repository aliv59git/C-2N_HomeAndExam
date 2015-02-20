using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //•	Write a program that prints to the console which day of the week is today.
    //•	Use System.DateTime.


    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Today is "+now.DayOfWeek+".");
    }
}
