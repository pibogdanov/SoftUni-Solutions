using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            int[] firstArray = new int[rowsCount];

            int[] secondArray = new int[rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArray[i] = input[0];

                    secondArray[i] = input[1];
                }

                else
                {
                    secondArray[i] = input[0];

                    firstArray[i] = input[1];
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));

            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
