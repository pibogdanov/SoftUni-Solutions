using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;

            int equalElementsCounter = 0;

            int equalNumbers = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;

                    if (counter > equalElementsCounter)
                    {
                        equalElementsCounter = counter;

                        equalNumbers = numbers[i];
                    }
                }

                else
                {
                    counter = 0;
                }
            }

            for (int i = 0; i <= equalElementsCounter; i++)
            {
                Console.Write($"{equalNumbers} ");
            }
        }
    }
}
