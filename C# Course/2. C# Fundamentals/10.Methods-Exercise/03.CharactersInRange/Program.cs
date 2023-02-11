using System;

namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbolOne = char.Parse(Console.ReadLine());

            char symbolTwo = char.Parse(Console.ReadLine());

            CharactersInRange(symbolOne, symbolTwo);
        }

        static void CharactersInRange(char symbolOne, char symbolTwo) 
        {
            int startCharacter = Math.Min(symbolOne, symbolTwo);

            int endCharacter = Math.Max(symbolOne, symbolTwo);

            for (int i = startCharacter + 1; i < endCharacter; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
