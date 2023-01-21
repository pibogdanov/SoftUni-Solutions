using System;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            for (int numberOne = 1; numberOne < 10; numberOne++)
            {
                for (int numberTwo = 1; numberTwo < 10; numberTwo++)
                {
                    for (int numberThree = 1; numberThree < 10; numberThree++)
                    {
                        for (int numberFour = 1; numberFour < 10; numberFour++)
                        {
                            bool isSpecial = (maxNumber % numberFour == 0) && (maxNumber % numberThree == 0) && (maxNumber % numberTwo == 0) && (maxNumber % numberOne == 0);
                            
                            if (isSpecial)
                            {
                                Console.Write($"{numberOne}{numberTwo}{numberThree}{numberFour} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
