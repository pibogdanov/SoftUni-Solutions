using System;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());

            double numberTwo = double.Parse(Console.ReadLine());

            double numberThree = double.Parse(Console.ReadLine());

            if ( (numberOne >= numberTwo) && (numberOne >= numberThree) )
            {
                Console.WriteLine(numberOne);

                if (numberTwo >= numberThree)
                {
                    Console.WriteLine(numberTwo);

                    Console.WriteLine(numberThree);
                }

                else
                {
                    Console.WriteLine(numberThree);

                    Console.WriteLine(numberTwo);
                }
            }

            else if ( (numberTwo >= numberOne) && (numberTwo >= numberThree) )
            {
                Console.WriteLine(numberTwo);

                if (numberOne >= numberThree)
                {
                    Console.WriteLine(numberOne);

                    Console.WriteLine(numberThree);
                }

                else
                {
                    Console.WriteLine(numberThree);

                    Console.WriteLine(numberOne);
                }
            }

            else
            {
                Console.WriteLine(numberThree);

                if (numberOne >= numberTwo)
                {
                    Console.WriteLine(numberOne);

                    Console.WriteLine(numberTwo);
                }

                else
                {
                    Console.WriteLine(numberTwo);

                    Console.WriteLine(numberOne);
                }
            }
        }
    }
}
