using System;
using System.Linq;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum = 0;

                for (int j = numbers.Length - 1; j > i; j--)
                {
                    rightSum += numbers[j];
                }

                int leftSum = 0;

                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);

                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
