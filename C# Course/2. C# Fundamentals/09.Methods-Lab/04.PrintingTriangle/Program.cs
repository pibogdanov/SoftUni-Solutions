using System;

namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int start = 1; start <= end; start++)
            {
                PrintLine(start);
            }

            for (int start = end - 1; start > 0; start--)
            {
                PrintLine(start);
            }
        }

        static void PrintLine(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
