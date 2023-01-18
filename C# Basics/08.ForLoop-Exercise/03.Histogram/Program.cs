using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = int.Parse(Console.ReadLine());

            int d1 = 0;

            int d2 = 0;

            int d3 = 0;

            int d4 = 0;

            int d5 = 0;

            for (int i = 0; i < finalNumber; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    d1++;
                }

                else if (number < 400)
                {
                    d2++;
                }

                else if (number < 600)
                {
                    d3++;
                }

                else if (number < 800)
                {
                    d4++;
                }

                else
                {
                    d5++;
                }
            }

            double p1 = 100.0 * d1 / finalNumber;

            double p2 = 100.0 * d2 / finalNumber;

            double p3 = 100.0 * d3 / finalNumber;

            double p4 = 100.0 * d4 / finalNumber;

            double p5 = 100.0 * d5 / finalNumber;

            Console.WriteLine($"{p1:F2}%");

            Console.WriteLine($"{p2:F2}%");

            Console.WriteLine($"{p3:F2}%");

            Console.WriteLine($"{p4:F2}%");

            Console.WriteLine($"{p5:F2}%");
        }
    }
}
