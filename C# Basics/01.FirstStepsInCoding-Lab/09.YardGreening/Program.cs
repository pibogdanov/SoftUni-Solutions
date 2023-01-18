using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMeterPrice = 7.61;

            double greeningSquareMetersCount = double.Parse(Console.ReadLine());

            double greeningSquareMeters = squareMeterPrice * greeningSquareMetersCount;

            double discount = greeningSquareMeters * 0.18;

            double greeningSquareMetersWithDiscount = greeningSquareMeters - discount;

            Console.WriteLine($"The final price is {greeningSquareMetersWithDiscount} lv.");

            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
