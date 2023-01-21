using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfParticipatedTournaments = int.Parse(Console.ReadLine());

            double startingPoints = double.Parse(Console.ReadLine());

            int pointsForWinner = 0;

            int pointsForFinalist = 0;

            int pointsForSemiFinalist = 0;

            int wonTournaments = 0;

            double points = 0;

            for (int i = 0; i < numberOfParticipatedTournaments; i++)
            {
                string stateInATournament = Console.ReadLine();

                if (stateInATournament == "W")
                {
                    pointsForWinner += 2000;

                    wonTournaments++;
                }

                else if (stateInATournament == "F")
                {
                    pointsForFinalist += 1200;
                }

                else if (stateInATournament == "SF")
                {
                    pointsForSemiFinalist += 720;
                }

                points = pointsForWinner + pointsForFinalist + pointsForSemiFinalist;
            }

            double totalPoints = startingPoints + points;
            Console.WriteLine($"Final points: {totalPoints}");

            double average = Math.Floor(points / numberOfParticipatedTournaments);
            Console.WriteLine($"Average points: {average}");

            double wonTournamentPercent = 100.0 * wonTournaments / numberOfParticipatedTournaments;
            Console.WriteLine($"{wonTournamentPercent:F2}%");
        }
    }
}
