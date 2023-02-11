using System;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productType = Console.ReadLine();

            int productCount = int.Parse(Console.ReadLine());

            double price = ProductType(productType, productCount);

            Console.WriteLine($"{price:F2}");
        }

        static double ProductType(string productType, int productCount)
        {
            double price = 0;

            if (productType == "coffee") 
            {
                price = 1.5 * productCount;
            }

            else if (productType == "water")
            {
                price = 1 * productCount;
            }

            else if (productType == "coke")
            {
                price = 1.4 * productCount;
            }

            else if (productType == "snacks")
            {
                price = 2 * productCount;
            }

            return price;
        }
    }
}
