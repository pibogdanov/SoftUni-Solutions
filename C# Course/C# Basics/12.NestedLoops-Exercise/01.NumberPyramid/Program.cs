﻿using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int counter = 1;

            bool isReady = false;   

            for (int rows = 1; rows <= maxNumber; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (counter > maxNumber)
                    {
                        isReady = true;

                        break;
                    }

                    Console.Write($"{counter} ");

                    counter++;
                }

                if (isReady)
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
