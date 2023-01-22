using System;

namespace _04.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());

            double cm = inch * 2.54;
            Console.WriteLine(cm);
        }
    }
}
