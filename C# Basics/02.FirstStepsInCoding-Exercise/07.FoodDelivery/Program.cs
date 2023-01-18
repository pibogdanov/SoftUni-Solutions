using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double perChickenMenu = 10.35;

            double perFishMenu = 12.4;

            double perVeganMenu = 8.15;

            double delivery = 2.5;

            int numberOfChickenMenu = int.Parse(Console.ReadLine());

            int numberOfFishMenu = int.Parse(Console.ReadLine());

            int numberOfVeganMenu = int.Parse(Console.ReadLine());

            double chickenMenu = numberOfChickenMenu * perChickenMenu;

            double fishMenu = numberOfFishMenu * perFishMenu;

            double veganMenu = numberOfVeganMenu * perVeganMenu;

            double sum = chickenMenu + fishMenu + veganMenu;

            double dessert = sum * 0.2;

            double totalSum = sum + dessert + delivery;

            Console.WriteLine(totalSum);
        }
    }
}
