using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beerKegsCount = int.Parse(Console.ReadLine());

            string bestVolume = "";

            decimal biggestVolume = 0;

            for (int i = 0; i < beerKegsCount; i++)
            {
                string model = Console.ReadLine();

                decimal radious = decimal.Parse(Console.ReadLine());

                int height = int.Parse(Console.ReadLine());

                decimal volume = (decimal)((decimal)Math.PI * radious * radious * height);

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;

                    bestVolume = model;
                }
            }

            Console.WriteLine(bestVolume);
        }
    }
}
