using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfFigure = Console.ReadLine();

            if (nameOfFigure == "square")
            {
                double squareLine = double.Parse(Console.ReadLine());

                double faceOfSquare = squareLine * squareLine;
                Console.WriteLine($"{faceOfSquare:F3}");
            }

            else if (nameOfFigure == "rectangle")
            {
                double rectangleLineA = double.Parse(Console.ReadLine());

                double rectangleLineB = double.Parse(Console.ReadLine());

                double faceOfRectangle = rectangleLineA * rectangleLineB;
                Console.WriteLine($"{faceOfRectangle:F3}");
            }

            else if (nameOfFigure == "circle")
            {
                double radiusCircle = double.Parse(Console.ReadLine());

                double faceOfCircle = Math.PI * radiusCircle * radiusCircle;
                Console.WriteLine($"{faceOfCircle:F3}");
            }

            else if (nameOfFigure == "triangle")
            {
                double triangleLine = double.Parse(Console.ReadLine());

                double triangleHeight = double.Parse(Console.ReadLine());

                double faceOfTriangle = triangleLine * triangleHeight / 2;
                Console.WriteLine($"{faceOfTriangle:F3}");
            }
        }
    }
}
