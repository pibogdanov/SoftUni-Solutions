using System;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int projects = int.Parse(Console.ReadLine());

            int hours = 3 * projects;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projects} project/s.");
        }
    }
}
