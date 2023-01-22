using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenuPrice = 10.35;

            double fishMenuPrice = 12.4;

            double veganMenuPrice = 8.15;

            double delivery = 2.5;

            int numberOfChickenMenu = int.Parse(Console.ReadLine());
            double chickenMenuTotalPrice = numberOfChickenMenu * chickenMenuPrice;

            int numberOfFishMenu = int.Parse(Console.ReadLine());
            double fishMenuTotalPrice = numberOfFishMenu * fishMenuPrice;

            int numberOfVeganMenu = int.Parse(Console.ReadLine());
            double veganMenuTotalPrice = numberOfVeganMenu * veganMenuPrice;

            double price = chickenMenuTotalPrice + fishMenuTotalPrice + veganMenuTotalPrice;

            double dessert = price * 0.2;

            double totalPrice = price + dessert + delivery;
            Console.WriteLine(totalPrice);
        }
    }
}
