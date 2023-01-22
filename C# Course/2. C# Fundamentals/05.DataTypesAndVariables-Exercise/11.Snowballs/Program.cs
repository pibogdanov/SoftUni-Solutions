using System;
using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());

            int snowballBestSnow = 0;

            int snowballBestTime = 0;

            int snowballBestQuality = 0;

            BigInteger snowballHighestValue = 0;

            for (int i = 0; i < snowballCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());

                int snowballTime = int.Parse(Console.ReadLine());

                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger divideSnowAndTime = (BigInteger)(snowballSnow / snowballTime);

                BigInteger snowballValue = BigInteger.Pow(divideSnowAndTime, snowballQuality);

                if (snowballValue > snowballHighestValue)
                {
                    snowballBestSnow = snowballSnow;

                    snowballBestTime = snowballTime;
                    
                    snowballBestQuality = snowballQuality;

                    snowballHighestValue = snowballValue;
                }
            }

            Console.WriteLine($"{snowballBestSnow} : {snowballBestTime} = {snowballHighestValue} ({snowballBestQuality})");
        }
    }
}
