using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 1; i <= ordersCount; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());

                int days = int.Parse(Console.ReadLine());

                int capsulesCount = int.Parse(Console.ReadLine());

                double orderPrice = capsulePrice * days * capsulesCount;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

                totalPrice += orderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
