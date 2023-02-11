using System;

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());

            int secondNumber = int.Parse(Console.ReadLine());

            int thirdNumber = int.Parse(Console.ReadLine());

            PrintTheSmallestNumber(firstNumber, secondNumber, thirdNumber);
        }

        static void PrintTheSmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if ( (firstNumber <= secondNumber) && (firstNumber <= thirdNumber) ) 
            {
                Console.WriteLine(firstNumber);
            }

            else if ( (secondNumber <= firstNumber) && (secondNumber <= thirdNumber) ) 
            {
                Console.WriteLine(secondNumber);
            }

            else
            {
                Console.WriteLine(thirdNumber);
            }
        }
    }
}
