using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseURL
{
    //•	Write a program that parses an URL address given in the format: [protocol]:
    //[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter URL address  in the format: [protocol]://[server]/[resource]");
        string str = Console.ReadLine();
        int colon = str.IndexOf(':');
        string protocol = str.Substring(0, colon);
        int surverEnd = str.IndexOf('/', colon + 3);
        Console.WriteLine("[protocol] = {0}", protocol);
        Console.WriteLine("[surver] = {0}", str.Substring(colon+3, surverEnd - colon-3));
        Console.WriteLine("[resource] = {0}", str.Substring(surverEnd));
    }
}
