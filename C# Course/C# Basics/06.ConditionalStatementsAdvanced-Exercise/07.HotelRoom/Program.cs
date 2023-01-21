using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();

            int nightsCount = int.Parse(Console.ReadLine());

            double studioTotalPrice = 0;

            double apartamentTotalPrice = 0;

            if ( (season == "May") || (season == "October") )
            {
                double studioPrice = 50;
                studioTotalPrice = studioPrice * nightsCount;

                double apartamentPrice = 65;
                apartamentTotalPrice = apartamentPrice * nightsCount;

                if (nightsCount > 14)
                {
                    studioTotalPrice *= 0.7;

                    apartamentTotalPrice *= 0.9;
                }

                else if (nightsCount > 7)
                {
                    studioTotalPrice *= 0.95;
                }
            }

            else if ( (season == "June") || (season == "September") )
            {
                double studioPrice = 75.2;
                studioTotalPrice = studioPrice * nightsCount;

                double apartamentPrice = 68.7;
                apartamentTotalPrice = apartamentPrice * nightsCount;

                if (nightsCount > 14)
                {
                    studioTotalPrice *= 0.8;

                    apartamentTotalPrice *= 0.9;
                }
            }

            else if ( (season == "July") || (season == "August") )
            {
                double studioPrice = 76;
                studioTotalPrice = studioPrice * nightsCount;

                double apartamentPrice = 77;
                apartamentTotalPrice = apartamentPrice * nightsCount;

                if (nightsCount > 14)
                {
                    apartamentTotalPrice *= 0.9;
                }
            }

            Console.WriteLine($"Apartment: {apartamentTotalPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioTotalPrice:F2} lv.");
        }
    }
}
