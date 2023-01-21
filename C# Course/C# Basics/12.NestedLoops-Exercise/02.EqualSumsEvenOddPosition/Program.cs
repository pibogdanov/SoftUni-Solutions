using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());

            int lastNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= lastNum; i++)
            {
                string currentNum = i.ToString();

                int oddSum = 0;

                int evenSum = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }

                    else
                    {
                        oddSum += currentDigit;
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
