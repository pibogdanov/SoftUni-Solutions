using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            GetMultipleOfEvenAndOdds(number);
        }

        static void GetMultipleOfEvenAndOdds(int number)
        {
            int sumEven = 0;

            int sumOdd = 0;

            while (number > 0)
            {
                int currentNumber = number % 10;

                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }

                else
                {
                    sumOdd += currentNumber;
                }

                number /= 10;
            }

            int result = sumEven * sumOdd;
            Console.WriteLine(result);
        }
    }
}
