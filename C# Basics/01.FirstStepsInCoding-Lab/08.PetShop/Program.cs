using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFoodPrice = 2.5;

            double catFoodPrice = 4;

            int dogFoodCount = int.Parse(Console.ReadLine());

            int catFoodCount = int.Parse(Console.ReadLine());

            double dogFoodTotalPrice = dogFoodPrice * dogFoodCount;

            double catFoodTotalPrice = catFoodPrice * catFoodCount;

            double totalPrice = dogFoodTotalPrice + catFoodTotalPrice;

            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
