using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
class DateInBulgarien
{
    //•	Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
    //    the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("bg-BG");
        Console.WriteLine("Please, enter date in format day.month.year hh:mm:ss ");
        //DateTime initialDate = DateTime.ParseExact(Console.ReadLine(), "dd.m.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
        DateTime initialDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(initialDate);
        Console.WriteLine(initialDate.AddHours(6).AddMinutes(30));



    }
}
