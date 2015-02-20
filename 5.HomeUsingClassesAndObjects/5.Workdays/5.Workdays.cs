using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //•	Write a method that calculates the number of workdays between today and given date, passed as parameter.
    //•	Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
    //    preliminary as array.
    public static int Workdays(DateTime givenDate)
    {
        int result = 0;
        DateTime now = DateTime.Now;
        DateTime tempDay1 = new DateTime(3 / 2 / 2015);
        DateTime tempDay2 = new DateTime(3 / 3 / 2015);
        DateTime tempDay3 = new DateTime(4 / 10 / 2015);
        DateTime tempDay4 = new DateTime(4 / 13 / 2015);
        DateTime tempDay5 = new DateTime(5 / 1 / 2015);
        DateTime tempDay6 = new DateTime(5 / 6 / 2015);
        DateTime tempDay7 = new DateTime(9 / 21 / 2015);
        DateTime tempDay8 = new DateTime(9 / 22 / 2015);
        DateTime tempDay9 = new DateTime(12 / 24 / 2015);
        DateTime tempDay10 = new DateTime(12 / 25 / 2015);
        DateTime tempDay11 = new DateTime(12 / 31 / 2015);
        DateTime tempDay12 = new DateTime(3 / 21 / 2015);
        DateTime tempDay13 = new DateTime(9 / 12 / 2015);
        DateTime tempDay14 = new DateTime(12 / 12 / 2015);
        int[] otherWorkDays = { tempDay12.DayOfYear, tempDay13.DayOfYear, tempDay14.DayOfYear };
        int[] holidays = { tempDay1.DayOfYear, tempDay2.DayOfYear, tempDay3.DayOfYear, tempDay4.DayOfYear, tempDay5.DayOfYear, tempDay6.DayOfYear, tempDay7.DayOfYear, tempDay8.DayOfYear, tempDay9.DayOfYear, tempDay10.DayOfYear, tempDay11.DayOfYear };
        result += givenDate.DayOfYear - now.DayOfYear;




        return result;
    }


    static void Main(string[] args)
    {




    }
}
