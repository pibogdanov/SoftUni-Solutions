using System;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clicksCount = int.Parse(Console.ReadLine());

            string message = "";

            for (int i = 0; i < clicksCount; i++)
            {
                string digits = Console.ReadLine();

                int digitLength = digits.Length;

                int digit = digits[0] - '0';

                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);

                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }

                int letterIndex = offset + digitLength - 1;

                message += (char)(letterIndex + 97);
            }

            Console.WriteLine(message);
        }
    }
}
