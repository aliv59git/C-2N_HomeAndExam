using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareRoot
{
    //•	Write a program that reads an integer number and calculates and prints its square root.
    //    o	If the number is invalid or negative, print Invalid number.
    //    o	In all cases finally print Good bye.
    //•	Use try-catch-finally block.

    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter integer number: ");
        try
        {
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine((double)Math.Sqrt(numb));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please, enter number: ");
        }
        catch (FormatException fe)
        {
            Console.Error.WriteLine("Invalid number format: {0}", fe.Message);
            Console.Error.WriteLine("{0}", fe.StackTrace);
            //Console.WriteLine(fe.ToString());
        }
        catch (ArgumentOutOfRangeException ae)
        {
            Console.WriteLine("From negative numbers Math.Sqrt() is not defined: {0}", ae.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
