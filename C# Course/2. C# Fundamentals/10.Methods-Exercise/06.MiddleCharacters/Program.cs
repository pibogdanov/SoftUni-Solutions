using System;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            CharacterCheck(text);
        }

        static void CharacterCheck(string text) 
        {
            int halfLengthCount = text.Length / 2;

            if (text.Length % 2 == 0)
            {
                char symbolOne = (char)(text[(halfLengthCount - 1)]);

                char symbolTwo = (char)(text[(halfLengthCount)]);
                Console.WriteLine($"{symbolOne}{symbolTwo}");
            }

            else
            {
                char symbol = (char)(text[halfLengthCount]);
                Console.WriteLine(symbol);
            }
        }
    }
}
