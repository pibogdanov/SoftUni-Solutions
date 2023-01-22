using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string season = Console.ReadLine().ToLower();

            if (budget < 101)
            {
                if (season == "summer")
                {
                    budget *= 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget:F2}");
                }

                else if (season == "winter")
                {
                    budget *= 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget:F2}");
                }
            }

            else if (budget < 1001)
            {
                if (season == "summer")
                {
                    budget *= 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget:F2}");
                }

                else if (season == "winter")
                {
                    budget *= 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget:F2}");
                }
            }

            else
            {
                if ( (season == "summer") || (season == "winter") )
                {
                    budget *= 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"Hotel - {budget:F2}");
                }
            }
        }
    }
}
