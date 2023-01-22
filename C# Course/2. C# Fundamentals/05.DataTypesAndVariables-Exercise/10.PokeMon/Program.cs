using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            double percent = power * 0.50;

            int distance = int.Parse(Console.ReadLine());

            int exhaustionFactor = int.Parse(Console.ReadLine());

            int counter = 0;

            while (power >= distance)
            {
                counter++;

                power -= distance;

                if ( (power == percent) && (exhaustionFactor != 0) )
                {
                    power /= exhaustionFactor;
                }
            }

            Console.WriteLine(power);

            Console.WriteLine(counter);
        }
    }
}
