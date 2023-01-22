using System;
using System.Linq;

namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversedInput = new (input.Reverse().ToArray());
            Console.WriteLine(reversedInput);
        }
    }
}
