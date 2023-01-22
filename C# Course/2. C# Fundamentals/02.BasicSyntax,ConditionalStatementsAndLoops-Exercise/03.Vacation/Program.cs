using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            string groupType = Console.ReadLine();

            string day = Console.ReadLine();

            double price = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = peopleCount * 8.45;

                    if (peopleCount > 29)
                    {
                        price *= 0.85;
                    }
                }

                else if (day == "Saturday")
                {
                    price = peopleCount * 9.8;

                    if (peopleCount > 29)
                    {
                        price *= 0.85;
                    }
                }

                else if (day == "Sunday")
                {
                    price = peopleCount * 10.46;

                    if (peopleCount > 29)
                    {
                        price *= 0.85;
                    }
                }
            }

            else if (groupType == "Business")
            {
                if (peopleCount > 99)
                {
                    peopleCount -= 10;
                }

                if (day == "Friday")
                {
                    price = peopleCount * 10.9;
                }

                else if (day == "Saturday")
                {
                    price = peopleCount * 15.6;
                }

                else if (day == "Sunday")
                {
                    price = peopleCount * 16;
                }
            }

            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = peopleCount * 15;
                }

                else if (day == "Saturday")
                {
                    price = peopleCount * 20;
                }

                else if (day == "Sunday")
                {
                    price = peopleCount * 22.5;
                }

                if ( (peopleCount > 9) && (peopleCount < 21) )
                {
                    price *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
