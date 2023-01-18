using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            int maxNumber = int.MinValue;

            for (int i = 0; i < finalNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (maxNumber < number)
                {
                    maxNumber = number;
                }

                if (minNumber > number)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");

            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
