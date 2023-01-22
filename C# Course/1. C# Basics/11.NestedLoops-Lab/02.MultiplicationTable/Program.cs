using System;

namespace _02.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int result = i * j;

                    Console.WriteLine($"{i} * {j} = {result}");
                }
            }
        }
    }
}
