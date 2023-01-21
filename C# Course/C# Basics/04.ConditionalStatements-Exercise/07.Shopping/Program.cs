using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int numberOfVideoCards = int.Parse(Console.ReadLine());
            double videoCardPrice = 250;
            double videoCardsPrice = numberOfVideoCards * videoCardPrice;

            int numberOfProcessors = int.Parse(Console.ReadLine());
            double processorPrice = videoCardsPrice * 0.35;
            double processorsPrice = numberOfProcessors * processorPrice;

            int numberOfRams = int.Parse(Console.ReadLine());
            double ramPrice = videoCardsPrice * 0.1;
            double ramsPrice = numberOfRams * ramPrice;           

            double totalPrice = videoCardsPrice + processorsPrice + ramsPrice;

            if (numberOfProcessors < numberOfVideoCards)
            {
                double discount = totalPrice * 0.15;

                totalPrice -= discount;
            }

            if (totalPrice > budget)
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
            }

            else
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"You have {moneyLeft:F2} leva left!");
            }
        }
    }
}
