using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnterNumber
{
    //    •	Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    //o	If an invalid number or non-number text is entered, the method should throw an exception.
    //•	Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

    static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Please, enter number in range {0} ... {1}", start, end);
        int numb;
        try
        {
            int.TryParse(Console.ReadLine(), out numb);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("You are not enter a number");
            throw;
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("Non-number text. Invalid number!", ae.Message);
            throw;
        }


        if ((start > numb) || (end < numb))
        {
            throw new ArgumentOutOfRangeException("Entered number is out of range!");
        }

        return numb;

    }

    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        try
        {        
            numbers[0] = ReadNumber(1, 100);
            for (int i = 1; i < 10; i++)
            {
                numbers[i] = ReadNumber(numbers[i - 1], 100);
            }
        }
        catch (ArgumentOutOfRangeException aor)
        {
            Console.WriteLine("Invalid number!", aor.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("You are entered non-number text:", ae.Message);
            throw;
        }
        catch (Exception)
        {
            throw;
        }

        Console.WriteLine("Your numbers in range 1...100 are: ");
        Console.WriteLine(string.Join(", ", numbers));
    }
}
