using System;

namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fibonacciNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumber(fibonacciNumber));
        }

        static int GetFibonacciNumber(int fibonacciNumber)
        {
            int[] fibonacciNumbers = new int[fibonacciNumber];

            int result = 0;

            for (int i = 0; i < fibonacciNumbers.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacciNumbers[i] = 1;
                }

                else if (i == 2)
                {
                    fibonacciNumbers[i] = 2;
                }

                else
                {
                    fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                }

                result = fibonacciNumbers[^1];
            }

            return result;
        }
    }
}
