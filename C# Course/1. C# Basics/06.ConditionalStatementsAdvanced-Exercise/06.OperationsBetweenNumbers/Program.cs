using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());

            int numberTwo = int.Parse(Console.ReadLine());

            char calculationType = char.Parse(Console.ReadLine());

            if (calculationType == '+')
            {
                double result = numberOne + numberTwo;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {calculationType} {numberTwo} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{numberOne} {calculationType} {numberTwo} = {result} - odd");
                }
            }

            else if (calculationType == '-')
            {
                double result = numberOne - numberTwo;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {calculationType} {numberTwo} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{numberOne} {calculationType} {numberTwo} = {result} - odd");
                }
            }

            else if (calculationType == '*')
            {
                double result = numberOne * numberTwo;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} {calculationType} {numberTwo} = {result} - even");
                }

                else
                {
                    Console.WriteLine($"{numberOne} {calculationType} {numberTwo} = {result} - odd");
                }
            }

            else if (calculationType == '/')
            {
                if (numberTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }

                else
                {
                    double result = 1.0 * numberOne / numberTwo;
                    Console.WriteLine($"{numberOne} {calculationType} {numberTwo} = {result:F2}");
                }
            }

            else if (calculationType == '%')
            {
                if (numberTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }

                else
                {
                    double result = numberOne % numberTwo;
                    Console.WriteLine($"{numberOne} {calculationType} {numberTwo} = {result}");
                }
            }
        }
    }
}
