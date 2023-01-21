using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resistancePerMeters = 15;

            double resistanceSeconds = 12.5;

            double record = double.Parse(Console.ReadLine());

            double meters = double.Parse(Console.ReadLine());

            double secondsForOneMeter = double.Parse(Console.ReadLine());

            double seconds = secondsForOneMeter * meters;

            double waterResistance = Math.Floor(meters / resistancePerMeters);

            double secondsSlowed = waterResistance * resistanceSeconds;

            double totalSeconds = seconds + secondsSlowed;

            if (totalSeconds < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSeconds:F2} seconds.");
            }

            else
            {
                double secondsSlower = totalSeconds - record;
                Console.WriteLine($"No, he failed! He was {secondsSlower:F2} seconds slower.");
            }
        }
    }
}
