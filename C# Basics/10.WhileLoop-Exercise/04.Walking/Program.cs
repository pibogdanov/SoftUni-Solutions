using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;

            int sumSteps = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Going home")
                {
                    int finalSteps = int.Parse(Console.ReadLine());

                    sumSteps += finalSteps;

                    break;
                }

                else
                {
                    int currentSteps = int.Parse(command);

                    sumSteps += currentSteps;

                    if (sumSteps >= stepsGoal)
                    {
                        break;
                    }
                }
            }

            if (sumSteps >= stepsGoal)
            {
                int stepsMore = sumSteps - stepsGoal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsMore} steps over the goal!");
            }

            else
            {
                int stepsLeft = stepsGoal - sumSteps;
                Console.WriteLine($"{stepsLeft} more steps to reach goal.");
            }
        }
    }
}
