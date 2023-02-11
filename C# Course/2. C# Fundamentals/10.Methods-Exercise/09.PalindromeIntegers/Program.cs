using System;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;

            while ( (number = Console.ReadLine()) != "END")
            {
                Console.WriteLine(PrintPalidrome(number).ToString().ToLower());
            }
        }

        static bool PrintPalidrome(string number)
        {
            string reverseNumber = "";

            for (int i = number.Length - 1; i >= 0; i--)
            {
                char symbol = number[i];

                reverseNumber += symbol;
            }

            if (reverseNumber == number)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}