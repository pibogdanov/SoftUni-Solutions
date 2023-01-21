using System;

namespace _01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 0;

            int minute = 0;

            for (int h = 0; h < 24; h++)
            {
                hour = h % 24;

                for (int m = 0; m < 60; m++)
                {
                    minute = m % 60;
                    
                    Console.WriteLine($"{hour}:{minute}");
                }
            }
        }
    }
}
