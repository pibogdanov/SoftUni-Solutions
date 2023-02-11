using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            if ( (choice == "int") || (choice == "char") || (choice == "string") )
            {
                GetMax(choice);
            }
        }

        static void GetMax(string choice) 
        {
            if (choice == "int")
            {
                int numberOne = int.Parse(Console.ReadLine());

                int numberTwo = int.Parse(Console.ReadLine());

                Console.WriteLine(Math.Max(numberOne, numberTwo));
            }

            else if (choice == "char") 
            {
                char symbolOne = char.Parse(Console.ReadLine());

                char symbolTwo = char.Parse(Console.ReadLine());

                Console.WriteLine( (char)Math.Max(symbolOne, symbolTwo) );
            }

            else if (choice == "string")
            {
                string textOne = Console.ReadLine();

                string textTwo = Console.ReadLine();

                if (textOne.CompareTo(textTwo) >= 0)
                {
                    Console.WriteLine(textOne);
                }

                else
                {
                    Console.WriteLine(textTwo);
                }
            }
        }
    }
}
