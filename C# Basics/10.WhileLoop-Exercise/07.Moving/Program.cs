using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());

            int legth = int.Parse(Console.ReadLine());

            int height = int.Parse(Console.ReadLine());

            double freeSpace = width * legth * height;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int currentBoxes = int.Parse(input);

                freeSpace -= currentBoxes;

                if (freeSpace < 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (freeSpace > 0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }

            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
        }
    }
}
