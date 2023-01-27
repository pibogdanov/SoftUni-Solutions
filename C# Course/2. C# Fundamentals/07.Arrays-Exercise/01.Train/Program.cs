using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int[] peopleCountInAWagon = new int[wagonsCount];

            int totalPeopleCount = 0;

            for (int i = 0; i < wagonsCount; i++)
            {
                peopleCountInAWagon[i] = int.Parse(Console.ReadLine());

                Console.Write($"{peopleCountInAWagon[i]} ");

                totalPeopleCount += peopleCountInAWagon[i];
            }

            Console.WriteLine();

            Console.WriteLine(totalPeopleCount);
        }
    }
}
