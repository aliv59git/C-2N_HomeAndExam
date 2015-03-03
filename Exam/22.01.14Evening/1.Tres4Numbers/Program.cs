using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.Tres4Numbers
{
    class Program
    {
        static string ConvertFromDecimalToNumeral(int d, BigInteger number)  //d is targer Base
        {
            string[] result = new string[100];
            int count = 99;
            if (number == 0)
            {
                result[99] = "LON+";
            }
            while (number > 0)
            {
                int temp = (int)(number % (BigInteger)d);
                switch (temp)
                {
                    case 0: result[count]="LON+"; break;
                    case 1: result[count] = "VK-"; break;
                    case 2: result[count] = "*ACAD"; break;
                    case 3: result[count] = "^MIM"; break;
                    case 4: result[count] = "ERIK|"; break;
                    case 5: result[count] = "SEY&"; break;
                    case 6: result[count] = "EMY>>"; break;
                    case 7: result[count] = "/TEL"; break;
                    case 8: result[count] = "<<DON"; break;
                    default: Console.WriteLine("InvalidNumber"); break;
                }
                number /= (BigInteger)d;
                count--;
            }

            return string.Join("", result);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number: ");
            try
            {
                BigInteger numb;
                BigInteger.TryParse(Console.ReadLine(), out numb);
                Console.WriteLine(ConvertFromDecimalToNumeral(9, numb));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
            
        }
    }
}
