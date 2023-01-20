using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();

            string books = Console.ReadLine();

            int numberOfBooks = 0;

            while (books != "No More Books")
            {
                if (books == favouriteBook)
                {
                    break;
                }

                numberOfBooks++;

                books = Console.ReadLine();
            }

            if (books == favouriteBook)
            {
                Console.WriteLine($"You checked {numberOfBooks} books and found it.");
            }

            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooks} books.");
            }
        }
    }
}
