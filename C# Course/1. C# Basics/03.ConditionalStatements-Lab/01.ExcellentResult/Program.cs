using System;

namespace _01.ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade > 5.49)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
