using System;

namespace _03.Numbers1ToNWithStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbersCount; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
