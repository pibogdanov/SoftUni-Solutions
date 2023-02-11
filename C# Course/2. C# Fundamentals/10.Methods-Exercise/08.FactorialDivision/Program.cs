using System;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());

            int numberTwo = int.Parse(Console.ReadLine());

            FirstFactorial(numberOne);

            SecondFactorial(numberTwo);

            Console.WriteLine($"{FinalResult(numberOne, numberTwo):F2}");
        }

        static double FirstFactorial(int numberOne)
        {
            double currentNumber = 1;

            if (numberOne > 0)
            {
                for (int number = numberOne; number > 0; number--)
                {
                    int actualNumber = number;

                    currentNumber = actualNumber * currentNumber;
                }
            }

            return currentNumber;
        }

        static double SecondFactorial(int numberTwo)
        {
            double currentNumber = 1;

            if (numberTwo > 0)
            {
                for (int number = numberTwo; number > 0; number--)
                {
                    int actualNumber = number;

                    currentNumber = actualNumber * currentNumber;
                }
            }

            return currentNumber;
        }

        static double FinalResult(int numberOne, int numberTwo)
        {
            double calculation = FirstFactorial(numberOne) / SecondFactorial(numberTwo);

            return calculation;
        }
    }
}
