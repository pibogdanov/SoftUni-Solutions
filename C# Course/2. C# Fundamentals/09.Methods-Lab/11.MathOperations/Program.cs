using System;

namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());

            char calculationType = char.Parse(Console.ReadLine());

            double numberTwo = double.Parse(Console.ReadLine());

            if ( (calculationType == '+') || (calculationType == '-') || (calculationType == '*') || (calculationType == '/') || (calculationType == '%') ) 
            {
                CalculationType(numberOne, calculationType, numberTwo);
            }
        }

        static void CalculationType(double numberOne, char calculationType, double numberTwo) 
        {

            if (calculationType == '+')
            {
                double result = numberOne + numberTwo; 
                Console.WriteLine(result);
            }

            else if (calculationType == '-') 
            {
                double result = numberOne - numberTwo; 
                Console.WriteLine(result);
            }

            else if (calculationType == '*')
            {
                double result = numberOne * numberTwo; 
                Console.WriteLine(result);
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
                    Console.WriteLine(result);
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
                    double result = numberOne / numberTwo;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
