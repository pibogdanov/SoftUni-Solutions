using System;
using System.Numerics;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            int musalla = 0;

            int montBlanc = 0;

            int kilimanjaro = 0;

            int k2 = 0;

            int everest = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int numberOfPeopleInAGroup = int.Parse(Console.ReadLine());

                if (numberOfPeopleInAGroup < 6)
                {
                    musalla += numberOfPeopleInAGroup;
                }

                else if (numberOfPeopleInAGroup < 13)
                {
                    montBlanc += numberOfPeopleInAGroup;
                }

                else if (numberOfPeopleInAGroup < 26)
                {
                    kilimanjaro += numberOfPeopleInAGroup;
                }

                else if (numberOfPeopleInAGroup < 41)
                {
                    k2 += numberOfPeopleInAGroup;
                }

                else
                {
                    everest += numberOfPeopleInAGroup;
                }
            }

            double totalCount = musalla + montBlanc + kilimanjaro + k2 + everest;

            double musallaPercent = 100 * musalla / totalCount;

            double montBlancPercent = 100 * montBlanc / totalCount;

            double kilimanjaroPercent = 100 * kilimanjaro / totalCount;

            double k2Percent = 100 * k2 / totalCount;

            double everestPercent = 100 * everest / totalCount;

            Console.WriteLine($"{musallaPercent:F2}%");

            Console.WriteLine($"{montBlancPercent:F2}%");

            Console.WriteLine($"{kilimanjaroPercent:F2}%");

            Console.WriteLine($"{k2Percent:F2}%");

            Console.WriteLine($"{everestPercent:F2}%");
        }
    }
}
