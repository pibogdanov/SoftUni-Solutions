using System;

namespace _11.RefactorVolumeОfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine()); 

            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());

            Console.Write($"Length: ");

            Console.Write($"Width: ");

            Console.Write($"Height: ");

            double volume = lenght * width * height / 3;
            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}
