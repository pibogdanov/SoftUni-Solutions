using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();

            int rows = int.Parse(Console.ReadLine());

            int columns = int.Parse(Console.ReadLine());

            double income = 0;

            if (movieType == "Premiere")
            {
                double premiere = 12;

                income = rows * columns * premiere;
            }

            else if (movieType == "Normal")
            {
                double normal = 7.5;

                income = rows * columns * normal;
            }

            else if (movieType == "Discount")
            {
                double discount = 5;

                income = rows * columns * discount;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}
