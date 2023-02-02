using System;

namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[linesCount][];

            for (int row = 0; row < linesCount; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                pascalTriangle[row][0] = 1;

                pascalTriangle[row][^1] = 1;

                for (int column = 1; column < row; column++)
                {
                    pascalTriangle[row][column] = pascalTriangle[row - 1][column - 1] + pascalTriangle[row - 1][column];
                }
            }

            for (int i = 0; i < linesCount; i++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[i]));
            }
        }
    }
}
