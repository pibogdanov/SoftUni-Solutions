using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            int musallaCounter = 0;

            int montBlancCounter = 0;

            int kilimanjaroCounter = 0;

            int k2Counter = 0;

            int everestCounter = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                int numberOfPeopleInAGroup = int.Parse(Console.ReadLine());

                if (numberOfPeopleInAGroup < 6)
                {
                    musallaCounter += numberOfPeopleInAGroup;
                }

                else if (numberOfPeopleInAGroup < 13)
                {
                    montBlancCounter += numberOfPeopleInAGroup;
                }

                else if (numberOfPeopleInAGroup < 26)
                {
                    kilimanjaroCounter += numberOfPeopleInAGroup;
                }

                else if (numberOfPeopleInAGroup < 41)
                {
                    k2Counter += numberOfPeopleInAGroup;
                }

                else
                {
                    everestCounter += numberOfPeopleInAGroup;
                }
            }

            int totalCounter = musallaCounter + montBlancCounter + kilimanjaroCounter + k2Counter + everestCounter;

            double musallaPercent = 100.0 * musallaCounter / totalCounter;
            Console.WriteLine($"{musallaPercent:F2}%");

            double montBlancPercent = 100.0 * montBlancCounter / totalCounter;
            Console.WriteLine($"{montBlancPercent:F2}%");

            double kilimanjaroPercent = 100.0 * kilimanjaroCounter / totalCounter;
            Console.WriteLine($"{kilimanjaroPercent:F2}%");

            double k2Percent = 100.0 * k2Counter / totalCounter;
            Console.WriteLine($"{k2Percent:F2}%");

            double everestPercent = 100.0 * everestCounter / totalCounter;
            Console.WriteLine($"{everestPercent:F2}%");
        }
    }
}
