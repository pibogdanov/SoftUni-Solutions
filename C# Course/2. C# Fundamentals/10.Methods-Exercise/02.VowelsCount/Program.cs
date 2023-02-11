using System;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            VowelsCount(text);
        }

        static void VowelsCount(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (
                          (currentSymbol == 'A') || (currentSymbol == 'a') ||
                          (currentSymbol == 'E') || (currentSymbol == 'e') ||
                          (currentSymbol == 'I') || (currentSymbol == 'i') ||
                          (currentSymbol == 'O') || (currentSymbol == 'o') ||
                          (currentSymbol == 'U') || (currentSymbol == 'u')
                   )
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
