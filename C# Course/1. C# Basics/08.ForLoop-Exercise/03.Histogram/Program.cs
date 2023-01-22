using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int fieldOne = 0;

            int fieldTwo = 0;

            int fieldThree = 0;

            int fieldFour = 0;

            int fieldFive = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    fieldOne++;
                }

                else if (number < 400)
                {
                    fieldTwo++;
                }

                else if (number < 600)
                {
                    fieldThree++;
                }

                else if (number < 800)
                {
                    fieldFour++;
                }

                else
                {
                    fieldFive++;
                }
            }

            double fieldOnePercent = 100.0 * fieldOne / numbersCount;
            Console.WriteLine($"{fieldOnePercent:F2}%");

            double fieldTwoPercent = 100.0 * fieldTwo / numbersCount;
            Console.WriteLine($"{fieldTwoPercent:F2}%");

            double fieldThreePercent = 100.0 * fieldThree / numbersCount;
            Console.WriteLine($"{fieldThreePercent:F2}%");

            double fieldFourPercent = 100.0 * fieldFour / numbersCount;
            Console.WriteLine($"{fieldFourPercent:F2}%");

            double fieldFivePercent = 100.0 * fieldFive / numbersCount;
            Console.WriteLine($"{fieldFivePercent:F2}%");
        }
    }
}
