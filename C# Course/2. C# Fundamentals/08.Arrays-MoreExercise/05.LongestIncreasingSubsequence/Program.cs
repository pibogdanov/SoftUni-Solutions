using System;
using System.Linq;

namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] index = new int[numbers.Length];

            int maxIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ( (numbers[i] > numbers[j]) && (index[i] <= index[j]) )
                    {
                        index[i] = index[j] + 1;

                        if (index[i] > index[maxIndex])
                        {
                            maxIndex = i;
                        }
                    }
                }
            }

            Print(maxIndex, numbers, index);
        }

        static void Print(int maxIndex, int[] numbers, int[] index)
        {
            bool isFirst = true;

            for (int i = 0; i < maxIndex; i++)
            {
                if ( (numbers[i] < numbers[maxIndex]) && (index[i] == index[maxIndex] - 1) && isFirst )
                {
                    isFirst = false;

                    Print(i, numbers, index);
                }
            }

            Console.Write($"{numbers[maxIndex]} ");
        }
    }
}