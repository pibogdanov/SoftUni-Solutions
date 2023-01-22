using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();

            int flowerCount = int.Parse(Console.ReadLine());

            int budget = int.Parse(Console.ReadLine());

            double rosePrice = 5;
            double rosesTotalPrice = flowerCount * rosePrice;

            double dahliaPrice = 3.8;
            double dahliasTotalPrice = flowerCount * dahliaPrice;

            double tulipPrice = 2.8;
            double tulipsTotalPrice = flowerCount * tulipPrice;

            double narcissusesPrice = 3;
            double narcissusesTotalPrice = flowerCount * narcissusesPrice;

            double gladiolusPrice = 2.5;
            double gladiolusTotalPrice = flowerCount * gladiolusPrice;

            double totalPrice = 0;

            if (flowerType == "Roses")
            {
                totalPrice = rosesTotalPrice;

                if (flowerCount > 80)
                {
                    totalPrice *= 0.9;
                }
            }

            else if (flowerType == "Dahlias")
            {
                totalPrice = dahliasTotalPrice;

                if (flowerCount > 90)
                {
                    totalPrice *= 0.85;
                }
            }

            else if (flowerType == "Tulips")
            {
                totalPrice = tulipsTotalPrice;

                if (flowerCount > 90)
                {
                    totalPrice *= 0.85;
                }
            }

            else if (flowerType == "Narcissus")
            {
                totalPrice = narcissusesTotalPrice;

                if (flowerCount < 120)
                {
                    totalPrice += narcissusesTotalPrice * 0.15;
                }
            }

            else if (flowerType == "Gladiolus")
            {
                totalPrice = gladiolusTotalPrice;

                if (flowerCount < 80)
                {
                    totalPrice += gladiolusTotalPrice * 0.2;
                }
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {moneyLeft:F2} leva left.");
            }

            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:F2} leva more.");
            }
        }
    }
}
