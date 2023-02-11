using System;

namespace _05.AddАndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());

            int numberTwo = int.Parse(Console.ReadLine());

            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(numberThree, Sum(numberOne, numberTwo)));
        }

        static double Sum(int numberOne, int numberTwo)
        {
            double sum = numberOne + numberTwo;
            return sum;
        }

        static double Subtract(int numberThree, double sum)
        {
            double result = sum - numberThree;
            return result;
        }
    }
}
