using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            int elevatorCapacity = int.Parse(Console.ReadLine());

            int coursesCount = peopleCount / elevatorCapacity;

            if (peopleCount % elevatorCapacity != 0) 
            {
                coursesCount++;
            }

            Console.WriteLine(coursesCount);
        }
    }
}
