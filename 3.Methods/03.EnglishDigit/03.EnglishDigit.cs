﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishDigit
{
    class Program
    {
        //•	Write a method that returns the last digit of given integer as an English word.

        static string LastDigitAsEnglishWord(int number)
        {
            string result=String.Empty;
            int numb = number % 10;
            switch (numb)
            {
                case 0: result = "zero"; break;
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
                default: result = "Invalid number!"; break;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter intiger number: ");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitAsEnglishWord(numb));
        }
    }
}
