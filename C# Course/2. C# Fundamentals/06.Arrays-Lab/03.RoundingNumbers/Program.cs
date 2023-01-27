using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int[] intNumbers = new int[realNumbers.Length];

            for (int i = 0; i < realNumbers.Length; i++)
            {
                intNumbers[i] = (int)Math.Round(realNumbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{realNumbers[i]} => {intNumbers[i]}");
            }
        }
    }
}
