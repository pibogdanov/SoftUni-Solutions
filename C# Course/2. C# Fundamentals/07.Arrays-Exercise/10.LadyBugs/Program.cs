using System;
using System.Linq;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counters = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] ladybugsArray = new int[counters];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if ( (initialIndexes[i] >= 0) && (initialIndexes[i] < ladybugsArray.Length) )
                {
                    ladybugsArray[initialIndexes[i]] = 1;
                }
            }

            string input;

            while ( (input = Console.ReadLine()) != "end" )
            {
                string[] command = input.Split();

                int ladybugIndex = int.Parse(command[0]);

                string direction = command[1];

                int flyLength = int.Parse(command[2]);

                if ( (ladybugIndex >= 0) && (ladybugIndex < ladybugsArray.Length) && (ladybugsArray[ladybugIndex] == 1) )
                {
                    ladybugsArray[ladybugIndex] = 0;

                    if (direction == "left")
                    {
                        flyLength = -flyLength;
                    }

                    while (true)
                    {
                        int sum = ladybugIndex + flyLength;

                        if ( (sum >= ladybugsArray.Length) || (sum < 0))
                        {
                            break;
                        }

                        if (ladybugsArray[sum] == 0)
                        {
                            ladybugsArray[sum] = 1;

                            break;
                        }

                        flyLength += flyLength;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", ladybugsArray));
        }
    }
}
