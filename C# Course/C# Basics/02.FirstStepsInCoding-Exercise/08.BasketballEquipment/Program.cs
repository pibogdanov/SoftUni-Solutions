using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cost = int.Parse(Console.ReadLine());

            double basketballShoes = cost * 0.6;

            double basketballOutfit = basketballShoes * 0.8;

            double basketballBall = basketballOutfit * 1 / 4;

            double basketballAccessories = basketballBall * 1 / 5;

            double equipment = cost + basketballShoes + basketballOutfit + basketballBall + basketballAccessories;
            Console.WriteLine(equipment);
        }
    }
}
