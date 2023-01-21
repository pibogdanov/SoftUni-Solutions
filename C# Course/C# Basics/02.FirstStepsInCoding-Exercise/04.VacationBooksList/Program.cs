using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());

            int pages = int.Parse(Console.ReadLine());

            int numberOfDays = int.Parse(Console.ReadLine());

            int hoursToRead = numberOfPages / pages / numberOfDays;

            Console.WriteLine(hoursToRead);
        }
    }
}
