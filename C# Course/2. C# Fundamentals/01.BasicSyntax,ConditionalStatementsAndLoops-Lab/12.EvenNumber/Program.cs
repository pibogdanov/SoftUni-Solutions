using System;

namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");

                    break;
                }

                else
                {
                    Console.WriteLine("Please write an even number.");

                    number = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}
