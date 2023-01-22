using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sourceYield = int.Parse(Console.ReadLine());

            int days = 0;

            int sum = 0;

            while (sourceYield > 99) 
            {
                days++;

                int spicePerDay = sourceYield - 26;

                sum += spicePerDay;

                sourceYield -= 10;
            }

            if (days > 0)
            {
                sum -= 26;
            }

            Console.WriteLine(days);

            Console.WriteLine(sum);
        }
    }
}
