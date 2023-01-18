using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.6;

            double talkingDoll = 3.0;

            double toyBear = 4.1;

            double minion = 8.2;

            double toyTruck = 2.0;

            double trip = double.Parse(Console.ReadLine());

            int numberOfPuzzles = int.Parse(Console.ReadLine());

            int numberOfTalkingDolls = int.Parse(Console.ReadLine());

            int numberOfToyBears = int.Parse(Console.ReadLine());

            int numberOfMinions = int.Parse(Console.ReadLine());

            int numberOfToyTrucks = int.Parse(Console.ReadLine());

            int numberOfToys = numberOfPuzzles + numberOfTalkingDolls + numberOfToyBears + numberOfMinions + numberOfToyTrucks;

            double puzzles = numberOfPuzzles * puzzle;

            double talkingDolls = numberOfTalkingDolls * talkingDoll;

            double toyBears = numberOfToyBears * toyBear;

            double minions = numberOfMinions * minion;

            double toyTrucks = numberOfToyTrucks * toyTruck;

            double totalPrice = puzzles + talkingDolls + toyBears + minions + toyTrucks;

            if (numberOfToys >= 50)
            {
                double discount = 0.25 * totalPrice;

                totalPrice -= discount;
            }

            double rent = 0.1 * totalPrice;

            totalPrice -= rent;

            if (totalPrice >= trip)
            {
                double profit = totalPrice - trip;
                Console.WriteLine($"Yes! {profit:F2} lv left.");
            }

            else
            {
                double neededMoney = trip - totalPrice;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }
    }
}
