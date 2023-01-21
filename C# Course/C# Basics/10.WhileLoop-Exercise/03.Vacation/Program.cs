using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacantionMoney = double.Parse(Console.ReadLine());

            double availableMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;

            int spendsDayCount = 0;

            while (availableMoney < vacantionMoney)
            {
                daysCount++;

                string action = Console.ReadLine();

                double sum = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    availableMoney += sum;

                    spendsDayCount = 0;
                }

                else if (action == "spend")
                {
                    availableMoney -= sum;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }

                    spendsDayCount++;

                    if (spendsDayCount > 4)
                    {
                        break;
                    }
                }
            }

            if (spendsDayCount > 4)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCount}");
            }

            else
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
