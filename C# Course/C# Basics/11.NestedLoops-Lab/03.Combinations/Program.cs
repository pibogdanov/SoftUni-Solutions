using System;

namespace _03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combinationsCount = int.Parse(Console.ReadLine());

            int validOptions = 0;

            for (int i = 0; i <= combinationsCount; i++)
            {
                for (int j = 0; j <= combinationsCount; j++)
                {
                    for (int k = 0; k <= combinationsCount; k++)
                    {
                        int number = i + j + k;

                        if (combinationsCount == number)
                        {
                            validOptions++;
                        }
                    }
                }
            }

            Console.WriteLine(validOptions);
        }
    }
}
