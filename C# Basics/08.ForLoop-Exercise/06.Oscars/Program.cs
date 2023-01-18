using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfAnActor = Console.ReadLine();

            double pointsFromTheAcademy = double.Parse(Console.ReadLine());

            int numberOfPeopleGivingRates = int.Parse(Console.ReadLine());

            double points = 0;

            for (int i = 0; i < numberOfPeopleGivingRates; i++)
            {
                string nameOfAPersonGivingARate = Console.ReadLine();

                double pointsFromThePerson = double.Parse(Console.ReadLine());

                pointsFromTheAcademy += ((nameOfAPersonGivingARate.Length * pointsFromThePerson) / 2);

                points = pointsFromTheAcademy;

                if (points >= 1250.5)
                {
                    break;
                }
            }

            points = pointsFromTheAcademy;

            if (points >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameOfAnActor} got a nominee for leading role with {points:F1}!");
            }

            else
            {
                double neededPoints = Math.Abs(1250.5 - points);
                Console.WriteLine($"Sorry, {nameOfAnActor} you need {neededPoints:F1} more!");
            }
        }
    }
}
