using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string input;

            while ( (input = Console.ReadLine()) != "end" )
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "exchange")
                {
                    int number = int.Parse(command[1]);

                    if ( (number >= 0) && (number < numbers.Length) )
                    {
                        numbers = RotateArrayByGivenN(numbers, number);
                    }

                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (command[0] == "max")
                {
                    PrintTheIndexOfTheMaxOddOrEvenNumberInArray(numbers, command[1]);
                }

                else if (command[0] == "min")
                {
                    PrintTheIndexOfTheMinOddOrEvenNumberInArray(numbers, command[1]);
                }

                else if (command[0] == "first")
                {
                    PrintTheFirstNOddOrEvenNumbersInArray(numbers, int.Parse(command[1]), command[2]);
                }

                else if (command[0] == "last")
                {
                    PrintTheLastNOddOrEvenNumbersInArray(numbers, int.Parse(command[1]), command[2]);
                }
            }

            Console.Write($"[{string.Join(", ", numbers)}]");
        }

        static int[] RotateArrayByGivenN(int[] numbers, int number)
        {
            int[] newNumbers = new int[numbers.Length];

            int currentNumber = number + 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (currentNumber >= numbers.Length)
                {
                    currentNumber = 0;
                }

                newNumbers[i] = numbers[currentNumber];

                currentNumber++;
            }

            return newNumbers;
        }

        static void PrintTheIndexOfTheMaxOddOrEvenNumberInArray(int[] numbers, string input)
        {
            if (input == "odd")
            {
                if (numbers.Any(x => x % 2 != 0))
                {
                    int maxOdd = numbers.Where(x => x % 2 != 0).Max();

                    int intdexOfMaxOdd = numbers.ToList().LastIndexOf(maxOdd);

                    Console.WriteLine(intdexOfMaxOdd);
                }

                else
                {
                    Console.WriteLine("No matches");
                }
            }

            if (input == "even")
            {
                if (numbers.Any(x => x % 2 == 0))
                {
                    int maxEven = numbers.Where(x => x % 2 == 0).Max();

                    int intdexOfMaxEven = numbers.ToList().LastIndexOf(maxEven);

                    Console.WriteLine(intdexOfMaxEven);
                }

                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void PrintTheIndexOfTheMinOddOrEvenNumberInArray(int[] numbers, string input)
        {
            if (input == "odd")
            {
                if (numbers.Any(x => x % 2 != 0))
                {
                    int minOdd = numbers.Where(x => x % 2 != 0).Min();

                    int intdexOfMinOdd = numbers.ToList().LastIndexOf(minOdd);

                    Console.WriteLine(intdexOfMinOdd);
                }

                else
                {
                    Console.WriteLine("No matches");
                }
            }

            if (input == "even")
            {
                if (numbers.Any(x => x % 2 == 0))
                {
                    int minEven = numbers.Where(x => x % 2 == 0).Min();

                    int intdexOfMinEven = numbers.ToList().LastIndexOf(minEven);

                    Console.WriteLine(intdexOfMinEven);
                }

                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void PrintTheFirstNOddOrEvenNumbersInArray(int[] numbers, int number, string oddEven)
        {
            if (number > numbers.Length)
            {
                Console.WriteLine("Invalid count");

                return;
            }

            List<int> sequence = new List<int>();

            if (oddEven == "odd")
            {
                if (numbers.Any(x => x % 2 != 0))
                {
                    sequence = numbers.Where(x => x % 2 != 0).ToList();
                }
            }

            else if (oddEven == "even")
            {
                if (numbers.Any(x => x % 2 == 0))
                {
                    sequence = numbers.Where(x => x % 2 == 0).ToList();
                }
            }

            Console.WriteLine($"[{string.Join(", ", sequence.Take(Math.Min(number, sequence.Count)).ToList())}]");
        }

        static void PrintTheLastNOddOrEvenNumbersInArray(int[] numbers, int input, string oddEven)
        {
            if (input > numbers.Length)
            {
                Console.WriteLine("Invalid count");

                return;
            }

            List<int> sequence = new List<int>();

            if (oddEven == "odd")
            {
                if (numbers.Any(x => x % 2 != 0))
                {
                    sequence = numbers.Where(x => x % 2 != 0).ToList();
                }
            }

            else if (oddEven == "even")
            {
                if (numbers.Any(x => x % 2 == 0))
                {
                    sequence = numbers.Where(x => x % 2 == 0).ToList();
                }
            }

            Console.WriteLine($"[{string.Join(", ", sequence.TakeLast(Math.Min(input, sequence.Count)).ToList())}]");
        }
    }
}
