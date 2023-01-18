using System;

namespace _05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = int.Parse(Console.ReadLine());

            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < finalNumber; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    salary -= 150;
                }

                else if (site == "Instagram")
                {
                    salary -= 100;
                }

                else if (site == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");

                    return;
                }
            }

            Console.WriteLine(salary);
        }
    }
}
