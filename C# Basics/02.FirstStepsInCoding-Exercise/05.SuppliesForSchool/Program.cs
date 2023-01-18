using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packetOfPens = 5.8;

            double packetOfMarkers = 7.2;

            double cleanerPerLitre = 1.2;

            int numberOfPacketsOfPens = int.Parse(Console.ReadLine());

            int numberOfPacketsOfMarkers = int.Parse(Console.ReadLine());

            int cleanerLitres = int.Parse(Console.ReadLine());

            double discountPercent = double.Parse(Console.ReadLine()) / 100;

            double totalPacketsOfPens = numberOfPacketsOfPens * packetOfPens;

            double totalPacketsOfMarkers = numberOfPacketsOfMarkers * packetOfMarkers;

            double totalCleanerLitres = cleanerLitres * cleanerPerLitre;

            double sum = totalPacketsOfPens + totalPacketsOfMarkers + totalCleanerLitres;

            double sumWithDiscount = sum - (sum * discountPercent);

            Console.WriteLine(sumWithDiscount);
        }
    }
}
