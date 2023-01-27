using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double sumEven = 0;

            double sumOdd = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }

                else
                {
                    sumOdd += numbers[i];
                }
            }

            double difference = sumEven - sumOdd;
            Console.WriteLine(difference);
        }
    }
}
