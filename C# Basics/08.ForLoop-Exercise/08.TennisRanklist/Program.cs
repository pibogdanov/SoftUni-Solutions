using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfParticipatedTournaments = int.Parse(Console.ReadLine());

            double startingPoints = double.Parse(Console.ReadLine());

            double pointsW = 0;

            double pointsF = 0;

            double pointsSF = 0;

            double points = 0;

            int wonTournaments = 0;

            double totalPoints = 0;

            double average = 0;

            double wonTournamentPercent = 0;

            for (int i = 0; i < numberOfParticipatedTournaments; i++)
            {
                string stateInATournament = Console.ReadLine();

                if (stateInATournament == "W")
                {
                    pointsW += 2000;

                    wonTournaments++;
                }

                else if (stateInATournament == "F")
                {
                    pointsF += 1200;
                }

                else if (stateInATournament == "SF")
                {
                    pointsSF += 720;
                }

                points = pointsW + pointsF + pointsSF;
            }

            totalPoints = startingPoints + points;
            Console.WriteLine($"Final points: {totalPoints}");

            average = Math.Floor(points / numberOfParticipatedTournaments);
            Console.WriteLine($"Average points: {average}");

            wonTournamentPercent = 100.0 * wonTournaments / numberOfParticipatedTournaments;
            Console.WriteLine($"{wonTournamentPercent:F2}%");
        }
    }
}
