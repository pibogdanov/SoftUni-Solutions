using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int width = int.Parse(Console.ReadLine());

            int piecesCount = length * width;

            string pieces;

            while (piecesCount >= 0 && (pieces = Console.ReadLine()) != "STOP")
            {
                piecesCount -= int.Parse(pieces);
            }

            if (piecesCount >= 0)
            {
                Console.WriteLine($"{piecesCount} pieces are left.");
            }

            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCount)} pieces more.");
            }
        }
    }
}
