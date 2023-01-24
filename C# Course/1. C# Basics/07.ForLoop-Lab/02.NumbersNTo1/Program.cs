using System;

namespace _02.NumbersNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());

            for (int i = start; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
