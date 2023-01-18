using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTVShow = Console.ReadLine();

            int runTime = int.Parse(Console.ReadLine());

            int freeTime = int.Parse(Console.ReadLine());

            double lunch = freeTime * 1 / 8.0;

            double breakTime = freeTime * 1 / 4.0;

            double totalTime = freeTime - lunch - breakTime;

            if (totalTime >= runTime)
            {
                double timeLeft = totalTime - runTime;
                Console.WriteLine($"You have enough time to watch {nameOfTVShow} and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }

            else
            {
                double neededTime = runTime - totalTime;
                Console.WriteLine($"You don't have enough time to watch {nameOfTVShow}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}
