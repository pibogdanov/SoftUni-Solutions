using System;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();

            int age = int.Parse(Console.ReadLine());

            if ( (0 <= age) && (age < 19) )
            {
                if (dayType == "weekday")
                {
                    Console.WriteLine("12$");
                }

                else if (dayType == "weekend")
                {
                    Console.WriteLine("15$");
                }

                else if (dayType == "holiday")
                {
                    Console.WriteLine("5$");
                }

                else
                {
                    Console.WriteLine("Error!");
                }
            }

            else if ( (18 < age) && (age < 65) )
            {
                if (dayType == "weekday")
                {
                    Console.WriteLine("18$");
                }

                else if (dayType == "weekend")
                {
                    Console.WriteLine("20$");
                }

                else if (dayType == "holiday")
                {
                    Console.WriteLine("12$");
                }

                else
                {
                    Console.WriteLine("Error!");
                }
            }

            else if ( (64 < age) && (age < 123) )
            {
                if (dayType == "weekday")
                {
                    Console.WriteLine("12$");
                }

                else if (dayType == "weekend")
                {
                    Console.WriteLine("15$");
                }

                else if (dayType == "holiday")
                {
                    Console.WriteLine("10$");
                }

                else
                {
                    Console.WriteLine("Error!");
                }
            }

            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
