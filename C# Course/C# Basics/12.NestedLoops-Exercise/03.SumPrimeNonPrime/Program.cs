using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;

            int sumNonPrime = 0;

            string command;

            while ( (command = Console.ReadLine()) != "stop" )
            {
                int currentNumber = int.Parse(command);

                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");

                    continue;
                }

                else if (currentNumber < 2)
                {
                    sumNonPrime += currentNumber;

                    continue;
                }
                
                bool isPrime = true;

                for (int divider = 2; divider <= Math.Sqrt(currentNumber); divider++)
                {
                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;

                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrime += currentNumber;
                }

                else
                {
                    sumNonPrime += currentNumber;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");

            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
