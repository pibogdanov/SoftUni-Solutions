using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();

            string dayOfTheWeek = Console.ReadLine();

            double numberOfFruits = double.Parse(Console.ReadLine());

            double price = 0;

            if ( (dayOfTheWeek == "Monday") || (dayOfTheWeek == "Tuesday") || (dayOfTheWeek == "Wednesday") || (dayOfTheWeek == "Thursday") || (dayOfTheWeek == "Friday") )
            {
                if (fruit == "banana")
                {
                    price = 2.5;
                }

                else if (fruit == "apple")
                {
                    price = 1.2;
                }

                else if (fruit == "orange")
                {
                    price = 0.85;
                }

                else if (fruit == "grapefruit")
                {
                    price = 1.45;
                }

                else if (fruit == "kiwi")
                {
                    price = 2.7;
                }

                else if (fruit == "pineapple")
                {
                    price = 5.5;
                }

                else if (fruit == "grapes")
                {
                    price = 3.85;
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else if ( (dayOfTheWeek == "Saturday") || (dayOfTheWeek == "Sunday") )
            {
                if (fruit == "banana")
                {
                    price = 2.7;
                }

                else if (fruit == "apple")
                {
                    price = 1.25;
                }

                else if (fruit == "orange")
                {
                    price = 0.9;
                }

                else if (fruit == "grapefruit")
                {
                    price = 1.6;
                }

                else if (fruit == "kiwi")
                {
                    price = 3;
                }

                else if (fruit == "pineapple")
                {
                    price = 5.6;
                }

                else if (fruit == "grapes")
                {
                    price = 4.2;
                }

                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }

            double totalPrice = price * numberOfFruits;

            if (totalPrice > 0)
            {
                Console.WriteLine($"{totalPrice:F2}");
            }
        }
    }
}
