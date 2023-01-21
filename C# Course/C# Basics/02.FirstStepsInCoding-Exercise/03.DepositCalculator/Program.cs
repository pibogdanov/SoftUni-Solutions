using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositValue = double.Parse(Console.ReadLine());

            int deadline = int.Parse(Console.ReadLine());

            double percentPerYear = double.Parse(Console.ReadLine()) / 100;

            double depositValueWithPercentPerYear = depositValue * percentPerYear / 12;

            double deadlineWithDepositValueWithPercentPerYear = deadline * depositValueWithPercentPerYear;

            double sum = depositValue + deadlineWithDepositValueWithPercentPerYear;
            Console.WriteLine(sum);
        }
    }
}
