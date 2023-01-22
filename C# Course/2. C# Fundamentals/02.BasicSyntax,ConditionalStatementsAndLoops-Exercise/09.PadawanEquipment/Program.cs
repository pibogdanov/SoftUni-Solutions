using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());

            double lightSaberPrice = double.Parse(Console.ReadLine());
            double lightSabersCount = studentsCount * 0.1;
            double lightSabersTotalCount = Math.Ceiling(lightSabersCount + studentsCount);
            double lightSabersPrice = lightSaberPrice * lightSabersTotalCount;

            double robePrice = double.Parse(Console.ReadLine());
            double robesPrice = robePrice * studentsCount;

            double beltPrice = double.Parse(Console.ReadLine());
            studentsCount -= studentsCount / 6;
            double beltsPrice = beltPrice * studentsCount;

            double sum = lightSabersPrice + robesPrice + beltsPrice;

            if (sum <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }

            else
            {
                double neededMoney = sum - budget;
                Console.WriteLine($"John will need {neededMoney:F2}lv more.");
            }
        }
    }
}
