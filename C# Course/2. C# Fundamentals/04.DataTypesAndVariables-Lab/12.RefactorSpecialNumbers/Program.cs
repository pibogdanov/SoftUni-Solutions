using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = i;

                int sum = 0;

                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;

                    currentNumber /= 10;
                }

                bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);

                if (isSpecialNum)
                {
                    Console.WriteLine($"{i} -> {isSpecialNum}");
                }

                else
                {
                    Console.WriteLine($"{i} -> {isSpecialNum}");
                }
            }
        }
    }
}
