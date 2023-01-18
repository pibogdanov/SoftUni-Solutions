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

            double rose = 5;

            double dahlia = 3.8;

            double tulip = 2.8;

            double narcissus = 3;

            double gladioli = 2.5;

            double roses = flowerCount * rose;

            double dahlias = flowerCount * dahlia;

            double tulips = flowerCount * tulip;

            double narcissuses = flowerCount * narcissus;

            double gladioluses = flowerCount * gladioli;

            double totalPrice = 0;

            if (flowerType == "Roses")
            {
                totalPrice = roses;

                if (flowerCount > 80)
                {
                    totalPrice -= roses * 0.1;
                }
            }

            else if (flowerType == "Dahlias")
            {
                totalPrice = dahlias;

                if (flowerCount > 90)
                {
                    totalPrice -= dahlias * 0.15;
                }
            }

            else if (flowerType == "Tulips")
            {
                totalPrice = tulips;

                if (flowerCount > 90)
                {
                    totalPrice -= tulips * 0.15;
                }
            }

            else if (flowerType == "Narcissus")
            {
                totalPrice = narcissuses;

                if (flowerCount < 120)
                {
                    totalPrice += narcissuses * 0.15;
                }
            }

            else if (flowerType == "Gladiolus")
            {
                totalPrice = gladioluses;

                if (flowerCount < 80)
                {
                    totalPrice += gladioluses * 0.2;
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
