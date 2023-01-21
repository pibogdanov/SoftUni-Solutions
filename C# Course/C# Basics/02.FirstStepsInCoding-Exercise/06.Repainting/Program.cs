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

            int neededCoveringNylon = int.Parse(Console.ReadLine()) + 2;
            double coveringNylon = neededCoveringNylon * coveringNylonPerMeter;

            int neededPaintLiters = int.Parse(Console.ReadLine());
            double moreNeededPaintLiters = neededPaintLiters * 0.1;
            double paint = (neededPaintLiters + moreNeededPaintLiters) * paintPerLiter;

            int neededPaintThinner = int.Parse(Console.ReadLine());
            double paintThinner = neededPaintThinner * paintТhinnerPerLiter;

            double sum = coveringNylon + paint + paintThinner + bags;

            double paymentPerHour = sum * 0.3;

            int workingHours = int.Parse(Console.ReadLine());
            double paymentForWorkers = paymentPerHour * workingHours;

            double totalSum = sum + paymentForWorkers;
            Console.WriteLine(totalSum);
        }
    }
}
