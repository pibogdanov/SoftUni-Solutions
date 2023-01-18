using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            int max = int.MinValue;

            for (int i = 1; i <= finalNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;

                if (number > max)
                {
                    max = number;
                }
            }

            sum -= max;

            if (sum == max)
            {
                Console.WriteLine("Yes");

                Console.WriteLine($"Sum = {sum}");
            }

            else
            {
                int difference = Math.Abs(sum - max);

                Console.WriteLine("No");

                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
