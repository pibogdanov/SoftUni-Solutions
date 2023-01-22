using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.6;

            double talkingDollPrice = 3;

            double toyBearPrice = 4.1;

            double minionPrice = 8.2;

            double toyTruckPrice = 2;

            double tripPrice = double.Parse(Console.ReadLine());

            int numberOfPuzzles = int.Parse(Console.ReadLine());
            double puzzles = numberOfPuzzles * puzzlePrice;

            int numberOfTalkingDolls = int.Parse(Console.ReadLine());
            double talkingDolls = numberOfTalkingDolls * talkingDollPrice;

            int numberOfToyBears = int.Parse(Console.ReadLine());
            double toyBears = numberOfToyBears * toyBearPrice;

            int numberOfMinions = int.Parse(Console.ReadLine());
            double minions = numberOfMinions * minionPrice;

            int numberOfToyTrucks = int.Parse(Console.ReadLine());
            double toyTrucks = numberOfToyTrucks * toyTruckPrice;

            int numberOfToys = numberOfPuzzles + numberOfTalkingDolls + numberOfToyBears + numberOfMinions + numberOfToyTrucks;

            double totalPrice = puzzles + talkingDolls + toyBears + minions + toyTrucks;

            if (numberOfToys > 49)
            {
                double discount = 0.25 * totalPrice;

                totalPrice -= discount;
            }

            double rent = 0.1 * totalPrice;

            totalPrice -= rent;

            if (totalPrice >= tripPrice)
            {
                double profit = totalPrice - tripPrice;
                Console.WriteLine($"Yes! {profit:F2} lv left.");
            }

            else
            {
                double neededMoney = tripPrice - totalPrice;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }
    }
}
