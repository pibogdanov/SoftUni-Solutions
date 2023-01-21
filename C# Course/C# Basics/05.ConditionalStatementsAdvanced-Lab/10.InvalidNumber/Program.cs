using System;

namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            bool isTrue = (num > 99 && num < 201 || num == 0);

            if (!isTrue)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
