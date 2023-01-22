using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            double bonus;

            if (points < 101)
            {
                bonus = 5;
            }

            else if (points > 1000)
            {
                bonus = points * 0.1;
            }

            else
            {
                bonus = points * 0.2;
            }

            if (points % 2 == 0)
            {
                bonus += 1;
            }

            else if (points % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);

            double totalPoints = points + bonus;
            Console.WriteLine(totalPoints);
        }
    }
}
