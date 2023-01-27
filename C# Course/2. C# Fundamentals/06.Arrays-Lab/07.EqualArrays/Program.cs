using System;
using System.Linq;

namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers1 = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double[] numbers2 = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double sum = 0;

            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] == numbers2[i])
                {
                    sum += numbers1[i];
                }

                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");

                    return;
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
