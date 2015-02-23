using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CodeDecode
{
    //•	Write a program that encodes and decodes a string using given encryption key (cipher).
    //•	The key consists of a sequence of characters.
    //•	The encoding/decoding is done by performing XOR (exclusive or) operation over the first
    //letter of the string with the first of the key, the second – with the second, etc. 
    //When the last key character is reached, the next is the first.

    static string CoderDecoder(string str, string cipher)
    {
        string result = String.Empty;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            char ch = (char)(str[i] ^ cipher[i % cipher.Length]);
            sb.Append(ch);
        }
        result = sb.ToString();

        return result;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter string to code/decode");
        string str = Console.ReadLine();
        Console.WriteLine("Please, enter encryption key (cipher)");
        string cipher = Console.ReadLine();
        string result = CoderDecoder(str, cipher);
        Console.WriteLine("Result of Encription is: \n{0}", result);
        Console.WriteLine("Result of Decriptin is:");
        Console.WriteLine(CoderDecoder(result, cipher));
    }
}
