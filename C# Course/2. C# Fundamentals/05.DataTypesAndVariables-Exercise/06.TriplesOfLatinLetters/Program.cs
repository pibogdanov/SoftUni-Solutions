using System;

namespace _06.TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int firstLetter = 0; firstLetter < end; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < end; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < end; thirdLetter++)
                    {
                        char firstChar = (char)('a' + firstLetter);
                        
                        char secondChar = (char)('a' + secondLetter);

                        char thirdChar = (char)('a' + thirdLetter);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
