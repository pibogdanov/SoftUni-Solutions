using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nightsCount = int.Parse(Console.ReadLine()) - 1;

            string roomType = Console.ReadLine();

            string feedback = Console.ReadLine();

            double roomForOnePerson = 18;

            double apartament = 25;

            double presidentApartament = 35;

            double price = 0;

            if (roomType == "room for one person")
            {
                price = nightsCount * roomForOnePerson;
            }

            else if (roomType == "apartment")
            {
                if (nightsCount < 11)
                {
                    price = nightsCount * apartament;

                    price *= 0.7;
                }

                else if (nightsCount < 16)
                {
                    price = nightsCount * apartament;

                    price *= 0.65;
                }

                else
                {
                    price = nightsCount * apartament;

                    price *= 0.5;
                }
            }

            else if (roomType == "president apartment")
            {
                if (nightsCount < 11)
                {
                    price = nightsCount * presidentApartament;

                    price *= 0.9;
                }

                else if (nightsCount < 16)
                {
                    price = nightsCount * presidentApartament;

                    price *= 0.85;
                }

                else
                {
                    price = nightsCount * presidentApartament;

                    price *= 0.8;
                }
            }

            if (feedback == "positive")
            {
                price += price * 0.25;
            }

            else if (feedback == "negative")
            {
                price *= 0.9;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
