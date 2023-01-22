using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double total = 0;

            while (input != "NoMoreMoney")
            {
                double increase = double.Parse(input);

                if (increase < 0)
                {
                    Console.WriteLine("Invalid operation!");

                    break;
                }

                else
                {
                    total += increase;
                    Console.WriteLine($"Increase: {increase:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
