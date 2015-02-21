using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempPasswordGenerator
{
    class Program
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;

        static Random rndGenerator = new Random();
        static void InsertRandomSymbols(int count, StringBuilder password, char[] symbols)
        {
            for (int i = 0; i < count; i++)
            {
                char symbol = symbols[rndGenerator.Next(0, symbols.Length)];
                int randomPosition = rndGenerator.Next(0, password.Length);
                password.Insert(randomPosition, symbol);
            }
        }
        static void Main(string[] args)
        {
            StringBuilder password = new StringBuilder();
            InsertRandomSymbols(2, password, CapitalLetters.ToCharArray());
            InsertRandomSymbols(2, password, SmallLetters.ToCharArray());
            InsertRandomSymbols(1, password, Digits.ToCharArray());
            InsertRandomSymbols(3, password, SpecialChars.ToCharArray());
            int count1 = rndGenerator.Next(0, 7);
            InsertRandomSymbols(count1, password, AllChars.ToCharArray());
            Console.WriteLine(password.ToString());
        }
    }
}
