using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            double laundry = double.Parse(Console.ReadLine());

            int toyPrice = int.Parse(Console.ReadLine());

            int totalMoney = 0;

            for (int currentYear = 1; currentYear <= age; currentYear++)
            {
                if (currentYear % 2 != 0)
                {
                    totalMoney += toyPrice;
                }

                else
                {
                    int moneyGain = currentYear / 2 * 10;

                    totalMoney += moneyGain - 1;
                }
            }

            if (totalMoney >= laundry)
            {
                double moneyLeft = totalMoney - laundry;
                Console.WriteLine($"Yes! {moneyLeft:F2}");
            }

            else
            {
                double moneyNeeded = laundry - totalMoney;
                Console.WriteLine($"No! {moneyNeeded:F2}");
            }
        }
    }
}
