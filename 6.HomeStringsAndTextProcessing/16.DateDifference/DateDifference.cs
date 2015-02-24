using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class DateDifference
{
    //•	Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.


    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("bg-BG");
        //DateTime parsed = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Please, enter first date in format day.month.year: ");
        DateTime parsed1 = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter second date in format day.month.year: ");
        DateTime parsed2 = DateTime.Parse(Console.ReadLine());
        int count = 0;
        for (int i = parsed1.Year; i < parsed2.Year; i++)
        {
            if (i % 4 == 0)
            {
                count++;
            }
        }


        if(parsed2.Year < parsed1.Year)
        {
            DateTime temp = parsed2;
            parsed2 = parsed1;
            parsed1 = temp;
        }
        if (parsed1.Year == parsed2.Year)
        {
            if(parsed2.DayOfYear < parsed1.DayOfYear)
            {
                DateTime temp = parsed2;
                parsed2 = parsed1;
                parsed1 = temp;
            } 
            Console.WriteLine(parsed2.DayOfYear - parsed1.DayOfYear+" days");
        }
        else if(parsed2.Year - parsed1.Year ==1)
        {
            Console.WriteLine(parsed2.DayOfYear + (365-parsed1.DayOfYear)+" days");
        }
        else
        {
            Console.WriteLine((parsed2.DayOfYear + 365 - parsed1.DayOfYear)+365*(parsed2.Year-parsed1.Year-1)+count+" days");
        }
    }
}
