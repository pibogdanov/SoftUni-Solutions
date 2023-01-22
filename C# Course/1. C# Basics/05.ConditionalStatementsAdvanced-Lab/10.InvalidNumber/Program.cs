using System;

namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if ( !( (number > 99 && number < 201) || (number == 0) ) )
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
