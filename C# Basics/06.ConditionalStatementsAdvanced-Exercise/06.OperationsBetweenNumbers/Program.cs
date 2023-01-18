using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());

            int number2 = int.Parse(Console.ReadLine());

            string calculationType = Console.ReadLine();

            double result = 0;

            if (calculationType == "+")
            {
                result = number1 + number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{number1} + {number2} = {result} - odd");
                }
            }

            else if (calculationType == "-")
            {
                result = number1 - number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{number1} - {number2} = {result} - odd");
                }
            }

            else if (calculationType == "*")
            {
                result = number1 * number2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{number1} * {number2} = {result} - odd");
                }
            }

            else if (calculationType == "/")
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }

                else
                {
                    result = number1 * 1.0 / number2;
                    Console.WriteLine($"{number1} / {number2} = {result:F2}");
                }
            }

            else if (calculationType == "%")
            {
                if (number2 == 0)
                {
                    Console.WriteLine($"Cannot divide {number1} by zero");
                }

                else
                {
                    result = number1 % number2;
                    Console.WriteLine($"{number1} % {number2} = {result}");
                }
            }
        }
    }
}
