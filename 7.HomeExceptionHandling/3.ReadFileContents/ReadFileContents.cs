﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

class ReadFileContents
{
    //•	Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its 
    //    contents and prints it on the console.
    //•	Find in MSDN how to use System.IO.File.ReadAllText(…).
    //•	Be sure to catch all possible exceptions and print user-friendly error messages.

    static void Main(string[] args)
    {
        string path = @"F:\VS\C#2N\C-2N_HomeAndExam\LICENSE";
        string readText = File.ReadAllText(path);
        string path1 = "..\\..\\LICENSE";  //file was copy in directory containing ReadFileContents.cs
        string readText1 = File.ReadAllText(path1);
        Console.WriteLine(readText);
        Console.WriteLine();
        Console.WriteLine(readText1);
    }
}