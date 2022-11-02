using System;
using static System.Console;

namespace CarpetCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double lengthinfeet = GetDimension("Length");
            double widthinfeet = GetDimension("width");

            WriteLine("length in feet is" + lengthinfeet.ToString("F2"));
            WriteLine("width in feet is" + widthinfeet.ToString("F2"));
        }

        static double GetDimension(string carpetside) // Carpet side can be lengt or width. 
        {
            
            Console.WriteLine("Enter the value : " + carpetside + "in feet");
            int feet = int.Parse(ReadLine());

            Console.WriteLine("Enter the value : " + carpetside + "in inches");
            int inches = int.Parse(ReadLine());

            double totaldimension = feet + (double)inches / 12;
            return totaldimension;
        }
    }
}

