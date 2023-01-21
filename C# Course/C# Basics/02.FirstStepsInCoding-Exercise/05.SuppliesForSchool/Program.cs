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
            double totalPacketsOfPens = numberOfPacketsOfPens * packetOfPens;

            int numberOfPacketsOfMarkers = int.Parse(Console.ReadLine());
            double totalPacketsOfMarkers = numberOfPacketsOfMarkers * packetOfMarkers;

            int cleanerLitres = int.Parse(Console.ReadLine());
            double totalCleanerLitres = cleanerLitres * cleanerPerLitre;

            double sum = totalPacketsOfPens + totalPacketsOfMarkers + totalCleanerLitres;

            double discountPercent = double.Parse(Console.ReadLine()) / 100;
            double discount = sum * discountPercent;

            double sumWithDiscount = sum - discount;
            Console.WriteLine(sumWithDiscount);
        }
    }
}
