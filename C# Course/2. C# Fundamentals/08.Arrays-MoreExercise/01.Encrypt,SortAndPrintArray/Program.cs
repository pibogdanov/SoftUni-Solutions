using System;

namespace _01.Encrypt_SortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stringsCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                string input = Console.ReadLine();

                int sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    char currentSymbol = input[j];

                    if (
                          (currentSymbol == 'A') || (currentSymbol == 'a') || 
                          (currentSymbol == 'E') || (currentSymbol == 'e') || 
                          (currentSymbol == 'I') || (currentSymbol == 'i') || 
                          (currentSymbol == 'O') || (currentSymbol == 'o') || 
                          (currentSymbol == 'U') || (currentSymbol == 'u')
                       )
                    {
                        sum += currentSymbol * input.Length;
                    }

                    else 
                    {
                        sum += currentSymbol / input.Length;
                    }
                }

                numbers[i] = sum;
            }

            Array.Sort(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
