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

                    price -= price * 0.3;
                }

                else if (nightsCount < 16)
                {
                    price = nightsCount * apartament;

                    price -= price * 0.35;
                }

                else
                {
                    price = nightsCount * apartament;

                    price -= price * 0.5;
                }
            }

            else if (roomType == "president apartment")
            {
                if (nightsCount < 11)
                {
                    price = nightsCount * presidentApartament;

                    price -= price * 0.1;
                }

                else if (nightsCount < 16)
                {
                    price = nightsCount * presidentApartament;

                    price -= price * 0.15;
                }

                else
                {
                    price = nightsCount * presidentApartament;

                    price -= price * 0.2;
                }
            }

            if (feedback == "positive")
            {
                price += price * 0.25;
            }

            else if (feedback == "negative")
            {
                price -= price * 0.1;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
