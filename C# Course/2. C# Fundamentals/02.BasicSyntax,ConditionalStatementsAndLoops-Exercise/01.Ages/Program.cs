using System;

namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if ( (0 <= age) && (age < 3) ) 
            {
                Console.WriteLine("baby");
            }

            else if (age < 14)
            {
                Console.WriteLine("child");
            }

            else if (age < 20)
            {
                Console.WriteLine("teenager");
            }

            else if (age < 66)
            {
                Console.WriteLine("adult");
            }

            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
