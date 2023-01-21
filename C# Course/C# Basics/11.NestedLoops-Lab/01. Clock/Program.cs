using System;

namespace _01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                int hour = hours % 24;

                for (int minutes = 0; minutes < 60; minutes++)
                {
                    int minute = minutes % 60;
                    
                    Console.WriteLine($"{hour}:{minute}");
                }
            }
        }
    }
}
