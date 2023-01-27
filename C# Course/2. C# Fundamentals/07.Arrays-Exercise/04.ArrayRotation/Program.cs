using System;
using System.Linq;

namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int swaps = int.Parse(Console.ReadLine());

            for (int i = 0; i < swaps; i++)
            {
                int end = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = end;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
