using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = int.Parse(Console.ReadLine()); 

            int sumLeft = 0;

            int sumRight = 0;

            int difference = 0;

            for (int i = 0; i < finalNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sumLeft += number;
            }

            for (int i = 0; i < finalNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sumRight += number;
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }

            else
            {
                difference = Math.Abs(sumRight - sumLeft);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
