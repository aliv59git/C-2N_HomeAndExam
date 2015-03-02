using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class RemoveWords
{
    //•	Write a program that removes from a text file all words listed in given another text file.
    //•	Handle all possible exceptions in your methods.

    static void Main(string[] args)
    {
        StreamReader strReader = new StreamReader(@"..\..\fileInput.txt");
        //StreamReader strReaderWords = new StreamReader(@"..\..\fileWords.txt");
        StreamWriter writer = new StreamWriter(@"..\..\result.txt");

        try
        {
            string[] words = File.ReadAllLines(@"..\..\fileWords.txt");     //.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?', '(', ')' });
            string regex = @"\b(" + string.Join("|", words) + @")\b";
            using (strReader)
            {
                string input = strReader.ReadToEnd();
                using (writer)
                {
                    writer.WriteLine(Regex.Replace(input, regex, string.Empty, RegexOptions.IgnoreCase));
                }
            }
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine("File not found!"+fnf.Message);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!");
        }
        catch (IOException)
        {
            throw;
        }
        catch (RegexMatchTimeoutException re)
        {
            Console.WriteLine(re.Message);
            throw;
        }
        catch (Exception)
        {
            throw;
        }

        StreamReader strResult = new StreamReader(@"..\..\result.txt");
        string resLine = strResult.ReadLine();
        while (resLine != null)
        {
            Console.WriteLine(resLine);
            resLine = strResult.ReadLine();
        }

    }
}
