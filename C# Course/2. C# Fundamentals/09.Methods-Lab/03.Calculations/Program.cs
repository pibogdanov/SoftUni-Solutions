using System;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculationType = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            CalculationType(calculationType, a, b);
        }

        static void CalculationType(string calculationType, int a, int b)
        {
            if (calculationType == "add")
            {
                int result = a + b;
                Console.WriteLine(result);
            }

            else if (calculationType == "multiply")
            {
                int result = a * b;
                Console.WriteLine(result);
            }

            else if (calculationType == "subtract")
            {
                int result = a % b;
                Console.WriteLine(result);
            }

            else if (calculationType == "divide")
            {
                double result = 1.0 * a / b;
                Console.WriteLine(result);
            }
        }
    }
}
