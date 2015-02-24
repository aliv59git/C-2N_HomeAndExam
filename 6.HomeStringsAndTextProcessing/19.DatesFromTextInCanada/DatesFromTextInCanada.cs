using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

class DatesFromTextInCanada
{
    //•	Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    //•	Display them in the standard date format for Canada.


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter text with dates in format DD.MM.YYYY");
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        string[] text = Console.ReadLine().Split(' ', ',', ';', '!', '?');
        for (int i = 0; i < text.Length; i++)
        {
            DateTime temp;
            DateTime.TryParse(text[i], out temp);
            if (temp.Year != 0001)
            {
                Console.WriteLine(temp);
                Console.WriteLine(temp.ToString("MM/dd/yyyy hh:mm:ss", new CultureInfo("en-CA")));
            }

        }
    }
}
