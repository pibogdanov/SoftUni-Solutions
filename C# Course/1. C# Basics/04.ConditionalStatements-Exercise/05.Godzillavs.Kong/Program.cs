using System;

namespace _05.Godzillavs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double decorPrice = 0.1 * budget;

            int numberOfActors = int.Parse(Console.ReadLine());

            double outfitPrice = double.Parse(Console.ReadLine());

            double outfitsPrice = numberOfActors * outfitPrice;

            if (numberOfActors > 149)
            {
                outfitsPrice *= 0.9;
            }
            
            double totalPrice = decorPrice + outfitsPrice;

            if (totalPrice > budget)
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }

            else
            {
                double profit = budget - totalPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {profit:F2} leva left.");
            }
        }
    }
}
