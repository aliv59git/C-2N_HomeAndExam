using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.IO;
using System.Linq;
using System.Net;
=======
using System.Linq;
>>>>>>> 285677908fdcf757c66ecd268250847de620a24a
using System.Text;
using System.Threading.Tasks;

class DownloadFile
{
<<<<<<< HEAD
    //•	Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    //•	Find in Google how to download files in C#.
    //•	Be sure to catch all exceptions and to free any used resources in the finally block.

    static void Main(string[] args)
    {
        WebClient client = new WebClient();
        try
        {
            client.DownloadFile("https://msdn.microsoft.com/bg-bg/library/618ayhy6.aspx", @"..\..\tmp1.html");
            client.DownloadFile("http://www.maswallpaper.com/wp-content/uploads/2014/06/all-animals-images-free-download-2.jpg", @"..\..\tmp2.jpg");
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine("Error: " + fnf.Message);
        }
        catch (FormatException)
        {
            throw;
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("Invalid path!"+ae.Message);
        }
        catch (Exception)
        {
            throw;
        }

        try
        {
            string path1 = @"..\..\tmp1.html";
            string path2 = @"..\..\tmp2.jpg";
            string textInFile1 = File.ReadAllText(path1);
            Console.WriteLine(textInFile1);
            string textInFile2 = File.ReadAllText(path2);
            //Console.WriteLine(textInFile2);
        }
        catch (FileNotFoundException)
        {
            throw;
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Wrong format"+fe.Message);
            throw;
        }
        catch (Exception)
        {
            throw;
        }

    }
}

//using System.Net;
//using System.IO;
////...
//using (WebClient client = new WebClient ()) // WebClient class inherits IDisposable
//{
//    client.DownloadFile("http://yoursite.com/page.html", @"C:\localfile.html");

//    // Or you can get the file content without saving it:
//    string htmlCode = client.DownloadString("http://yoursite.com/page.html");
//    //...
//}




=======
    //•	Write a program that downloads a file from Internet (e.g. Ninja image) and stores 
    //    it the current directory.
    //•	Find in Google how to download files in C#.
    //•	Be sure to catch all exceptions and to free any used resources in the finally block.

    static string DownloadFile(string fileName)
    {
        string result = string.Empty;



        return result;
    }

    static void Main(string[] args)
    {
    }
}
>>>>>>> 285677908fdcf757c66ecd268250847de620a24a
