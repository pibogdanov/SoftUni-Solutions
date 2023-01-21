using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());

            string season = Console.ReadLine();

            int fishermenCount = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                price = 3000;
            }

            else if ( (season == "Summer") || (season == "Autumn") )
            {
                price = 4200;
            }

            else if (season == "Winter")
            {
                price = 2600;
            }

            if (fishermenCount < 7)
            {
                price *= 0.9;
            }

            else if (fishermenCount < 12)
            {
                price *= 0.85;
            }

            else
            {
                price *= 0.75;
            }

            if ( (season != "Autumn") && (fishermenCount % 2 == 0) )
            {
                price *= 0.95;
            }

            if (budget >= price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }

            else
            {
                double moneyNeeded = price - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
            }
        }
    }
}
