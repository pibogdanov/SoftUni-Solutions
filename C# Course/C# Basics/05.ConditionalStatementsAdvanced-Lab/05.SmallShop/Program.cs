using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productType = Console.ReadLine();

            string city = Console.ReadLine();

            double numberOfProducts = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (productType == "coffee")
                {
                    double coffee = numberOfProducts * 0.5;
                    Console.WriteLine(coffee);
                }

                else if (productType == "water")
                {
                    double water = numberOfProducts * 0.8;
                    Console.WriteLine(water);
                }

                else if (productType == "beer")
                {
                    double beer = numberOfProducts * 1.2;
                    Console.WriteLine(beer);
                }

                else if (productType == "sweets")
                {
                    double sweets = numberOfProducts * 1.45;
                    Console.WriteLine(sweets);
                }

                else if (productType == "peanuts")
                {
                    double peanuts = numberOfProducts * 1.6;
                    Console.WriteLine(peanuts);
                }
            }

            else if (city == "Plovdiv")
            {
                if (productType == "coffee")
                {
                    double coffee = numberOfProducts * 0.4;
                    Console.WriteLine(coffee);
                }

                else if (productType == "water")
                {
                    double water = numberOfProducts * 0.7;
                    Console.WriteLine(water);
                }

                else if (productType == "beer")
                {
                    double beer = numberOfProducts * 1.15;
                    Console.WriteLine(beer);
                }

                else if (productType == "sweets")
                {
                    double sweets = numberOfProducts * 1.3;
                    Console.WriteLine(sweets);
                }

                else if (productType == "peanuts")
                {
                    double peanuts = numberOfProducts * 1.5;
                    Console.WriteLine(peanuts);
                }
            }

            else if (city == "Varna")
            {
                if (productType == "coffee")
                {
                    double coffee = numberOfProducts * 0.45;
                    Console.WriteLine(coffee);
                }

                else if (productType == "water")
                {
                    double water = numberOfProducts * 0.7;
                    Console.WriteLine(water);
                }

                else if (productType == "beer")
                {
                    double beer = numberOfProducts * 1.1;
                    Console.WriteLine(beer);
                }

                else if (productType == "sweets")
                {
                    double sweets = numberOfProducts * 1.35;
                    Console.WriteLine(sweets);
                }

                else if (productType == "peanuts")
                {
                    double peanuts = numberOfProducts * 1.55;
                    Console.WriteLine(peanuts);
                }
            }
        }
    }
}
