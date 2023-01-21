using System;

namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());

            string timeOfTheDay = Console.ReadLine();

            if (timeOfTheDay == "Morning")
            {
                if ( (degrees > 9) && (degrees < 19) )
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Sweatshirt and Sneakers.");
                }

                else if (degrees < 25)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }

                else if (degrees > 24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }
            }

            else if (timeOfTheDay == "Afternoon")
            {
                if ( (degrees > 9) && (degrees < 19) )
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }

                else if (degrees < 25)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your T-Shirt and Sandals.");
                }

                else if (degrees > 24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Swim Suit and Barefoot.");
                }
            }

            else if (timeOfTheDay == "Evening")
            {
                if ( (degrees > 9) && (degrees < 19) )
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }

                else if (degrees < 25)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }

                else if (degrees > 24)
                {
                    Console.WriteLine($"It's {degrees} degrees, get your Shirt and Moccasins.");
                }
            }
        }
    }
}
