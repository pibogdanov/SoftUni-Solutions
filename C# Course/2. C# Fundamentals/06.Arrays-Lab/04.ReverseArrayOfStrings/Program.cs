using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().Reverse().ToArray();
            Console.WriteLine(string.Join(" ", text));
        }
    }
}