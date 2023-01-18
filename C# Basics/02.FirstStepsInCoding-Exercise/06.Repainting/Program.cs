using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coveringNylonPerMeter = 1.5;

            double paintPerLiter = 14.5;

            double paintТhinnerPerLiter = 5;

            double bags = 0.4;

            int neededCoveringNylon = int.Parse(Console.ReadLine());

            int neededPaintLiters = int.Parse(Console.ReadLine());

            int neededPaintThinner = int.Parse(Console.ReadLine());

            int workingHours = int.Parse(Console.ReadLine());

            double coveringNylon = (neededCoveringNylon + 2) * coveringNylonPerMeter;

            double paint = (neededPaintLiters + (neededPaintLiters * 0.1)) * paintPerLiter;

            double paintThinner = neededPaintThinner * paintТhinnerPerLiter;

            double sum = coveringNylon + paint + paintThinner + bags;

            double paymentForWorkers = (sum * 0.3) * workingHours;

            double totalSum = sum + paymentForWorkers;

            Console.WriteLine(totalSum);
        }
    }
}
