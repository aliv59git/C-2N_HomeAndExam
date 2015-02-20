using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
//    •	Write methods that calculate the surface of a triangle by given:
//o	Side and an altitude to it;
//o	Three sides;
//o	Two sides and an angle between them;
//•	Use System.Math.


    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter side and atitude to it, separated by comma space: ");
        string[] str = Console.ReadLine().Split(',');
        double side = double.Parse(str[0]);
        double atitude = double.Parse(str[1]);
        Console.WriteLine("Surface of a triangle is: {0}", side*atitude/2);
        Console.WriteLine();

        Console.WriteLine("Please, enter a, b, c for a triangle, separated by comma and space: ");
        string[] str1 = Console.ReadLine().Split(',');
        double a = double.Parse(str1[0]);
        double b = double.Parse(str1[1]);
        double c = double.Parse(str1[2]);
        double p = (a + b + c) / 2;
        Console.WriteLine("Surface of a triangle is: {0}", Math.Sqrt(p*(p-a)*(p-b)*p-c));
        Console.WriteLine();

        Console.WriteLine("Please, enter a, b and angle(a, b) in degrees for a triangle, separated by comma and space: ");
        string[] str2 = Console.ReadLine().Split(',');
        double a1 = double.Parse(str2[0]);
        double b1 = double.Parse(str2[1]);
        double alpha = double.Parse(str2[2]);
        double alphaInRad = alpha*Math.PI/180;
        Console.WriteLine("Surface of a triangle is: {0}", a1*b1*Math.Sin(alphaInRad)/2);
    }
}
