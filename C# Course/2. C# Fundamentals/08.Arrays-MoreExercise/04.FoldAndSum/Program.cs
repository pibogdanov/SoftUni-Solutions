using System;
using System.Linq;

namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startingNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = startingNumbers.Length / 4;

            int[] firstRow = new int[k * 2];

            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstRow[i] = startingNumbers[k - i - 1];
            }

            for (int i = firstRow.Length / 2; i < firstRow.Length; i++)
            {
                firstRow[i] = startingNumbers[startingNumbers.Length - 1 - i + k];
            }

            int[] secondRow = new int[k * 2];

            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = startingNumbers[k + i];
            }

            int[] result = new int[k * 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
