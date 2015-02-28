using System;
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
        string readText = string.Empty;
        string readText1 = string.Empty;
        try
        {
            string path = @"F:\VS\C#2N\C-2N_HomeAndExam\LICENSE";
            readText = File.ReadAllText(path);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid Directory. Entered Path is invalid.");
            Console.WriteLine();
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine("Error: " + fnf.Message);
        }
        catch (ArgumentNullException)
        {
            throw;
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
            throw;
        }
        catch (System.Security.SecurityException se)
        {
            Console.WriteLine("The file is security entries." + se.Message);
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            string path1 = @"..\..\LICENSE";  //file was copy in directory containing ReadFileContents.cs
            readText1 = File.ReadAllText(path1);
            Console.WriteLine(readText1);
        }
        Console.WriteLine(readText);
    }
}
