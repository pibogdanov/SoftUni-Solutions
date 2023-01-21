using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbersCount; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= 150;
                }

                else if (website == "Instagram")
                {
                    salary -= 100;
                }

                else if (website == "Reddit")
                {
                    salary -= 50;
                }

                if (salary < 1)
                {
                    Console.WriteLine("You have lost your salary.");

                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
