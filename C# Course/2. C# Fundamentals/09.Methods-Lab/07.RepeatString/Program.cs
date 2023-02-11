using System;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int repeatCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < repeatCount; i++)
            {
                RepeatString(text);
            }
        }

        static void RepeatString(string text) 
        {
            Console.Write(text);
        }
    }
}
