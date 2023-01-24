using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfAnActor = Console.ReadLine();

            double pointsFromTheAcademy = double.Parse(Console.ReadLine());

            int numberOfJuries = int.Parse(Console.ReadLine());

            double points = pointsFromTheAcademy;

            for (int i = 0; i < numberOfJuries; i++)
            {
                string nameOfAJury = Console.ReadLine();

                double pointsFromAJury = double.Parse(Console.ReadLine());

                points += nameOfAJury.Length * pointsFromAJury / 2;

                if (points > 1250.49)
                {
                    break;
                }
            }

            if (points > 1250.49)
            {
                Console.WriteLine($"Congratulations, {nameOfAnActor} got a nominee for leading role with {points:F1}!");
            }

            else
            {
                double neededPoints = 1250.5 - points;
                Console.WriteLine($"Sorry, {nameOfAnActor} you need {neededPoints:F1} more!");
            }
        }
    }
}
