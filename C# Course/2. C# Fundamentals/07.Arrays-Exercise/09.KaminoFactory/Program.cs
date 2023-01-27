using System;
using System.Linq;

namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());

            int[] bestSample = new int[DNALength];

            int leftmostIndex = DNALength;

            int bestSampleSequenseLenght = 0;

            int bestSampleSum = 0;

            int bestSampleNumber = 1;

            string command = Console.ReadLine();

            int sampleNumber = 0;

            while (command != "Clone them!")
            {
                int[] currentSample = command.Split("!".ToArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                sampleNumber++;

                int currentSequenceLenght = 0;

                int previousSequenceLenght = 0;

                int currentLongestSequence = 0;

                int leftmostIndexInCurrentArray = DNALength;

                int currentSampleSum = 0;

                for (int i = 0; i < currentSample.Length; i++)
                {
                    if (currentSample[i] == 1)
                    {
                        currentSequenceLenght++;

                        currentSampleSum++;
                    }

                    else
                    {
                        previousSequenceLenght = currentSequenceLenght;

                        currentSequenceLenght = 0;
                    }

                    if (currentSequenceLenght > previousSequenceLenght)
                    {
                        currentLongestSequence = currentSequenceLenght;

                        leftmostIndexInCurrentArray = i - currentSequenceLenght + 1;
                    }
                }

                if (currentLongestSequence > bestSampleSequenseLenght)
                {
                    bestSampleSequenseLenght = currentLongestSequence;

                    leftmostIndex = leftmostIndexInCurrentArray;

                    bestSample = currentSample;

                    bestSampleNumber = sampleNumber;

                    bestSampleSum = currentSampleSum;
                }

                else if (currentLongestSequence == bestSampleSequenseLenght)
                {
                    if (leftmostIndexInCurrentArray < leftmostIndex)
                    {
                        leftmostIndex = leftmostIndexInCurrentArray;

                        bestSampleSum = currentSampleSum;

                        bestSample = currentSample;

                        bestSampleNumber = sampleNumber;
                    }

                    else if (leftmostIndex == leftmostIndexInCurrentArray)
                    {
                        if (currentSampleSum > bestSampleSum)
                        {
                            bestSampleSum = currentSampleSum;

                            bestSample = currentSample;

                            bestSampleNumber = sampleNumber;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {bestSampleSum}.");
            Console.WriteLine(string.Join(" ", bestSample));
        }
    }
}
