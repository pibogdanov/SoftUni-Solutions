using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtCm = int.Parse(Console.ReadLine());

            int widthCm = int.Parse(Console.ReadLine());

            int heightCm = int.Parse(Console.ReadLine());

            double volumeOfTheAquarium = lenghtCm * widthCm * heightCm;

            double volumeInLiters = volumeOfTheAquarium / 1000;

            double percentOfUsedPlace = double.Parse(Console.ReadLine()) / 100;
            double lossLiters = volumeInLiters * percentOfUsedPlace;

            double neededLiters = volumeInLiters - lossLiters;
            Console.WriteLine(neededLiters);
        }
    }
}
