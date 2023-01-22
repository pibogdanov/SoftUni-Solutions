using System;

namespace _05.MonthPrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("January");
            }

            else if (choice == 2)
            {
                Console.WriteLine("February");
            }

            else if (choice == 3)
            {
                Console.WriteLine("March");
            }

            else if (choice == 4)
            {
                Console.WriteLine("April");
            }

            else if (choice == 5)
            {
                Console.WriteLine("May");
            }

            else if (choice == 6)
            {
                Console.WriteLine("June");
            }

            else if (choice == 7)
            {
                Console.WriteLine("July");
            }

            else if (choice == 8)
            {
                Console.WriteLine("August");
            }

            else if (choice == 9)
            {
                Console.WriteLine("September");
            }

            else if (choice == 10)
            {
                Console.WriteLine("October");
            }

            else if (choice == 11)
            {
                Console.WriteLine("November");
            }

            else if (choice == 12)
            {
                Console.WriteLine("December");
            }

            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
