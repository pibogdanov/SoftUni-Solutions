using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int litersCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < litersCount; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());

                int waterTankCapacity = 255;

                if (litersToPour <= waterTankCapacity - sum)
                {
                    sum += litersToPour;
                }

                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            Console.WriteLine(sum);
        }
    }
}
