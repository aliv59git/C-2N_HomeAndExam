using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordDictionary
{
//•	A dictionary is stored as a sequence of text lines containing words and their explanations.
//•	Write a program that enters a word and translates it by using the dictionary.
    static string TranslateWord(string word)
    {
        string[] littleDiction = new string[] //or Console.ReadLine().Split(new char[]{'\n'}).Trim(',');
        {
            "Backup - This is an extra copy of a file or document",
            "Browser - This is the program you use to browse files. A web browser will browse internet files, like Firefox or Internet Explorer.",
            "Burn a CD - This means to make a copy of data onto a CD. It is called “burn” because it actually heats up the CD.",
            "Cursor - Usually a small arrow on the screen that moves when you move the mouse. The cursor is used to make a selection.",
            "Caret or Insertion Point - This is that small blinking line that shows you where your next typed letter or number will go.",
            "Data - Any information stored by a computer. It can be files, E-mails, video games, songs, pictures, etc.",
            "Desktop - This is the screen that appears if you are not browsing the Internet, reading a file, or playing a game. Your icons are on this screen.", 
            "Download - This is the process where you copy something from another computer or the Internet, and save it on your computer. ",
            "Drag and drop - To do this, you click on something and hold the button down. This will move the object you clicked on and will leave it where you let go of the button. So it drags it and drops it.",
            "E_mail - This is simply a way to send a message from one computer to another.",
            "FAQ - This is an abbreviation for Frequently Asked Questions.",
            "Graphic - This is a picture or an image. ",
            "Homepage - This is the first page you see when you open your browser.  You can make any page your homepage.  ",
            "Icon - This is a small symbol or picture that represents a program or other things.",
            "Internet - Many computers that are connected like a web so you can see what other computer operators show you and you can show them things as well.",
            "Logon - You have to do this to get access to a computer. You just type in a certain name or code.",
            "Memory - This is the data that a computer stores. Long term memory must be saved to the hard drive.",
            "Password - This is a secret code to protect your data and can keep others from accessing your computer.",
            "Right click - When you right click on the mouse, you are given a menu of options.",
            "Screensaver - This is a picture that pops up when you are not using your computer.",
            "Shortcut - When you click on an icon, it is a shortcut to a file or program.  ",
            "Software - This is all the instructions for the computer or a program designed to do different things. Examples are: Microsoft Word, Internet Explorer, and Windows. ",
            "Spam - This is an abbreviation for \"sending particularly annoying messages\"; it stands for unwanted e-mail.",
            "Task bar - The bar beside the Start button that shows what programs are open.",
            "URL - The address of documents and resources on the internet.",
            "User - Anyone using a computer.",
            "Virus - Software that was written to do bad stuff to your computer. ",
            "Wallpaper - A picture or design on your desktop for decoration."
        };
        StringBuilder sbTerm = new StringBuilder();
        for (int i = 0; i < littleDiction.Length; i++)
			{
			    sbTerm.Append(littleDiction[i].Substring(0, littleDiction[i].IndexOf('-')).Trim(' '));
			}
        string terms = string.Join(", ", sbTerm.ToString());
        //Console.WriteLine(terms);
        string result = string.Empty;
        for (int i = 0; i < littleDiction.Length; i++)
        {
            string temp = littleDiction[i].Substring(0, littleDiction[i].IndexOf('-')).Trim(' ').ToLower();
            if (word.ToLower().Trim() == temp)
            {
                result = littleDiction[i].Substring(littleDiction[i].IndexOf('-') + 1).Trim(' ');
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter term from this: ");
        Console.WriteLine();
        string[] terms = {
             "Backup", "Browser", "Burn a CD", "Cursor", "Caret or Insertion Point",
            "Data", "Desktop", "Download", "Drag and drop", "E_mail",
            "FAQ",
            "Graphic",
            "Homepage",
            "Icon",
            "Internet",
            "Logon",
            "Memory",
            "Password",
            "Right click",
            "Screensaver",
            "Shortcut",
            "Software",
            "Spam",
            "Task bar",
            "URL",
            "User",
            "Virus",
            "Wallpaper"};
        Console.WriteLine(string.Join(", ", terms));
        Console.WriteLine();
        string str = Console.ReadLine();
        Console.WriteLine(TranslateWord(str));
        Console.WriteLine();
    }
}
