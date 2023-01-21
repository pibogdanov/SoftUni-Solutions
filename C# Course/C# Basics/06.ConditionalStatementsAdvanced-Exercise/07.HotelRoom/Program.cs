using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();

            int nightsCount = int.Parse(Console.ReadLine());

            double studio = 0;

            double studioPrice = 0;

            double apartament = 0;

            double apartamentPrice = 0;

            if (season == "May" || season == "October")
            {
                studio = 50;

                studioPrice = studio * nightsCount;

                apartament = 65;

                apartamentPrice = apartament * nightsCount;

                if (nightsCount > 7 && nightsCount < 15)
                {
                    studio -= studio * 0.05;

                    studioPrice = studio * nightsCount;
                }

                else if (nightsCount > 14)
                {
                    studio -= studio * 0.3;

                    studioPrice = studio * nightsCount;

                    apartament -= apartament * 0.1;

                    apartamentPrice = apartament * nightsCount;
                }
            }

            else if (season == "June" || season == "September")
            {
                studio = 75.2;

                studioPrice = studio * nightsCount;

                apartament = 68.7;

                apartamentPrice = apartament * nightsCount;

                if (nightsCount > 14)
                {
                    studio -= studio * 0.2;

                    studioPrice = studio * nightsCount;

                    apartament -= apartament * 0.1;

                    apartamentPrice = apartament * nightsCount;
                }
            }

            else if (season == "July" || season == "August")
            {
                studio = 76;

                studioPrice = studio * nightsCount;

                apartament = 77;

                apartamentPrice = apartament * nightsCount;

                if (nightsCount > 14)
                {
                    apartament -= apartament * 0.1;

                    apartamentPrice = apartament * nightsCount;
                }
            }

            Console.WriteLine($"Apartment: {apartamentPrice:F2} lv.");

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
