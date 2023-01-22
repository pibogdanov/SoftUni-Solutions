using System;

namespace _03.Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine()) + 15;

            if (minutes > 59 )
            {
                hours += 1;

                minutes -= 60;
            }

            if (hours > 23)
            {
                hours -= 24;
            }
            
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
