using System;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rectangleWidth = double.Parse(Console.ReadLine());

            double rectangeHeight = double.Parse(Console.ReadLine());

            RectangleArea(rectangleWidth, rectangeHeight);
        }

        static void RectangleArea(double rectangleWidth, double rectangeHeight)
        {
            double rectangleArea = rectangeHeight * rectangleWidth;
            Console.WriteLine(rectangleArea);
        }
    }
}
