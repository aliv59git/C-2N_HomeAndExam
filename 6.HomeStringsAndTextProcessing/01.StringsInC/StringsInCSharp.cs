using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringsInCSharp
{
    //•	Describe the strings in C#.
    //•	What is typical for the string data type?
    //•	Describe the most important methods of the String class.


    static void Main(string[] args)
    {
        //Strings are sequences of characters. Each CHaracter is Unicode Symbol. Represented by a string data type in C# System.String;
        //String objects contain an immutable (read-only) sequence of characters. Strings use Unicode to support multiple languages and alphabets.
        //System.String is reference type. String objects are like array of characters. (char[]). 
        //Have fixed length:  String.Length; Elements can be accessed directly by index [0, ... str.Length-1]
        //Declaring string: string str1; System.String str2; String str3;   Creating strings: 
        //string str = Console.ReadLine(); string str = "abc"; string str1 = str; StringBuilder result = new StringBuilder(); return result.ToString(); 
        //Console.Write("This is a string"); Console.WriteLine("And this is also a string")     Comparing strings:
        //int result = string.Compare(str1, str2, true); //Case-insensitive; int resultSensitive = string.Compare(str1, str2, false);
        //result == 0  if equals, result < 0 - str1 is before str2, result > 0 - str1 is after str2; if(str1 == str2) or if(str1.Equals(str2)) -> by default is case-sensitive
        //Most Important methods for String class: String.Compare(); String.Concat(); String.Copy(); String.Equals(); String.Format(); String.IsNullOrEmpty(); String.Join(); 
        string str = String.Empty;
        //Most Important methods for String instance:
            //str.CompareTo(); str.Concat(); str.CopyTo(); str.Equals(); str.IndexOf(); str.Insert(); str.LastIndexOf(); str.Length; str.Max(); str.Min(); str.OrderBy(); str.OrderByDescending();
            //str.PadLeft(); str.PadRight(); str.Remove(); str.Replace(); str.Reverse(); str.Select(); str.Split(); str.Sum(); str.ToArray(); str.ToCharArray(); str.ToDictionary();
            //str.ToList(); str.ToLower(); str.ToString(); str.ToUpper(); str.Trim(); str.TrimEnd(); str.TrimStart(); str.

        //String.Compare() - Comparer for case-sensitive (with false) and case-insensitive (with true); String.Compare(str1, str2, false);
        // String.Format("{0, -10:D3}", number); Formats with placeholders for output.
        //Console.WriteLine(string.Join(", ", int[] numbers)); - Concatenate the numbers in array, separated by ", " and print the string.

        //Concatenating of strings; Searching in strings; Replacing in strings; Extracting Substrings; Splitting strings; Replacing substrings, Deleting substrings, Changing Character casing, Trimming etc. 
    }
}
