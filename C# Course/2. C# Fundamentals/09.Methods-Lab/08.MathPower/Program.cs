using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            int power = int.Parse(Console.ReadLine());

            MathPower(number, power);
        }

        static void MathPower(double number, int power) 
        {
            double result = Math.Pow(number, power);
            Console.WriteLine(result);
        }
    }
}
