using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double premiere = 12;

            double normal = 7.5;

            double discount = 5;

            string movieType = Console.ReadLine();

            int rows = int.Parse(Console.ReadLine());

            int columns = int.Parse(Console.ReadLine());

            double income = 0;

            if (movieType == "Premiere")
            {
                income = rows * columns * premiere;
            }

            else if (movieType == "Normal")
            {
                income = rows * columns * normal;
            }

            else if (movieType == "Discount")
            {
                income = rows * columns * discount;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}
