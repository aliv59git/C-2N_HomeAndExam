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
    public static int WorkDays(DateTime givenDate)
    {
        int result = 0;
        DateTime now = DateTime.Now;
        DateTime tempDay1 = new DateTime(2015, 3, 2);
        DateTime tempDay2 = new DateTime(2015, 3, 3);
        DateTime tempDay3 = new DateTime(2015, 4, 10);
        DateTime tempDay4 = new DateTime(2015, 4, 13);
        DateTime tempDay5 = new DateTime(2015, 5, 1);
        DateTime tempDay6 = new DateTime(2015, 5, 6);
        DateTime tempDay7 = new DateTime(2015, 9, 21);
        DateTime tempDay8 = new DateTime(2015, 9, 22);
        DateTime tempDay9 = new DateTime(2015, 12, 24);
        DateTime tempDay10 = new DateTime(2015, 12, 25);
        DateTime tempDay11 = new DateTime(2015, 12, 31);
        DateTime tempDay12 = new DateTime(2015, 3, 21);
        DateTime tempDay13 = new DateTime(2015, 9, 12);
        DateTime tempDay14 = new DateTime(2015, 12, 12);
        int[] otherWorkDays = { tempDay12.DayOfYear, tempDay13.DayOfYear, tempDay14.DayOfYear };
        int[] holidays = { tempDay1.DayOfYear, tempDay2.DayOfYear, tempDay3.DayOfYear, tempDay4.DayOfYear, tempDay5.DayOfYear, tempDay6.DayOfYear, tempDay7.DayOfYear, tempDay8.DayOfYear, tempDay9.DayOfYear, tempDay10.DayOfYear, tempDay11.DayOfYear };
        result += givenDate.DayOfYear - now.DayOfYear;
        int count1 = 0;
        int count2 = 0;
        if ((int)now.DayOfWeek == 6)
        {
            result +=1;
        }
        else if((int)now.DayOfWeek ==7)
        {
            result += 2;
        }
        else if ((int)givenDate.DayOfWeek == 6)
        {
            result += 2;
        }
        else if ((int)givenDate.DayOfWeek == 7)
        {
            result +=1;
        }
        if (result % 7 == 0)
        {
            result -= (result * 2 / 7);
        }
        else
        {
            result -= ((1 + result / 7) * 2);
        }


        for (int i = 1; i <= givenDate.DayOfYear - now.DayOfYear; i++)
        {
            if ((now.DayOfYear + i) == tempDay12.DayOfYear)
            {
                count1++;
            }
            else if ((now.DayOfYear + i) == tempDay13.DayOfYear)
            {
                count1++;
            }
            else if ((now.DayOfYear + i) == tempDay14.DayOfYear)
            {
                count1++;
            }

        }
        for (int j = 1; j <= givenDate.DayOfYear - now.DayOfYear; j++)
        {
            for (int k = 0; k < holidays.Length; k++)
            {
                if ((now.DayOfYear + j) == holidays[k])
                {
                    count2++;
                }
            }
        }
        result -= (count2 - count1);
        
        return result;
    }

    public static int WorkDaysN(DateTime givenDate)
    {
        int result = 0;
        DateTime now = DateTime.Now;
        DateTime tempDay1 = new DateTime(2015, 3, 2);
        DateTime tempDay2 = new DateTime(2015, 3, 3);
        DateTime tempDay3 = new DateTime(2015, 4, 10);
        DateTime tempDay4 = new DateTime(2015, 4, 13);
        DateTime tempDay5 = new DateTime(2015, 5, 1);
        DateTime tempDay6 = new DateTime(2015, 5, 6);
        DateTime tempDay7 = new DateTime(2015, 9, 21);
        DateTime tempDay8 = new DateTime(2015, 9, 22);
        DateTime tempDay9 = new DateTime(2015, 12, 24);
        DateTime tempDay10 = new DateTime(2015, 12, 25);
        DateTime tempDay11 = new DateTime(2015, 12, 31);
        DateTime tempDay12 = new DateTime(2015, 3, 21);
        DateTime tempDay13 = new DateTime(2015, 9, 12);
        DateTime tempDay14 = new DateTime(2015, 12, 12);
        int[] otherWorkDays = { tempDay12.DayOfYear, tempDay13.DayOfYear, tempDay14.DayOfYear };
        int[] holidays = { tempDay1.DayOfYear, tempDay2.DayOfYear, tempDay3.DayOfYear, tempDay4.DayOfYear, tempDay5.DayOfYear, tempDay6.DayOfYear, tempDay7.DayOfYear, tempDay8.DayOfYear, tempDay9.DayOfYear, tempDay10.DayOfYear, tempDay11.DayOfYear };
        for (int i = 1; i <= givenDate.DayOfYear-now.DayOfYear; i++)
        {
            DateTime temp = now.AddDays(i);
            if ((temp.DayOfWeek.ToString() != "Saturday") && (temp.DayOfWeek.ToString() != "Sunday"))
            {
                result++;
            }
            if ((temp.DayOfYear == tempDay12.DayOfYear) || (temp.DayOfYear == tempDay13.DayOfYear) || (temp.DayOfYear == tempDay14.DayOfYear))
            {
                result++;
            }


            for (int j = 0; j < holidays.Length; j++)
            {
                if (temp.DayOfYear == holidays[j])
                {
                    result--;
                }
            }
        }

        return result;
    }



    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        Console.WriteLine("Please, enter given date in format mm/dd/yyyy :");
        DateTime givenDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("There are {0} workdays from now to {1}", WorkDays(givenDate), givenDate);
        Console.WriteLine("There are {0} workdays from now to {1}", WorkDaysN(givenDate), givenDate);
    }

}
