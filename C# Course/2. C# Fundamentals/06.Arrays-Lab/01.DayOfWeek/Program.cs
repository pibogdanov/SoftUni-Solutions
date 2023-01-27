using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] week =
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            int choice = int.Parse(Console.ReadLine());

            if ( (0 < choice) && (choice < 8) )
            {
                Console.WriteLine(week[choice - 1]);
            }

            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
