using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());

            int secondTime = int.Parse(Console.ReadLine());

            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            int minutes = totalTime / 60;

            int seconds = totalTime % 60;
            
            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}
