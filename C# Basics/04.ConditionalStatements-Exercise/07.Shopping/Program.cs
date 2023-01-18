using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double videoCard = 250;

            int numberOfVideoCards = int.Parse(Console.ReadLine());

            double videoCards = numberOfVideoCards * videoCard;

            double processor = videoCards * 0.35;

            int numberOfProcessors = int.Parse(Console.ReadLine());

            double processors = numberOfProcessors * processor;

            double ram = videoCards * 0.1;

            int numberOfRams = int.Parse(Console.ReadLine());

            double rams = numberOfRams * ram;           

            double totalPrice = videoCards + processors + rams;

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
