using System;

namespace _02.NumbersNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = int.Parse(Console.ReadLine());

            for (int i = startingNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
