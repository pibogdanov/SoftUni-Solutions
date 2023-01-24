using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int sum = 0;

            int counter = 0;

            for (int i = 1; i < 101; i += 2)
            {
                Console.WriteLine(i);

                counter++;

                sum += i;

                if (counter == numbersCount)
                {
                    Console.WriteLine($"Sum: {sum}");

                    break;
                }
            }
        }
    }
}
