using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGrades = int.Parse(Console.ReadLine());

            string presentationType = Console.ReadLine();

            int gradeCount = 0;

            int totalGradeCount = 0;

            double grades = 0;

            double sum = 0;

            while (true)
            {
                if (presentationType == "Finish")
                {
                    double totalAverage = sum / totalGradeCount;

                    Console.WriteLine($"Student's final assessment is {totalAverage:F2}.");

                    break;
                }

                double grade = double.Parse(Console.ReadLine());

                grades += grade;

                gradeCount++;

                sum += grade;

                if (numberOfGrades == gradeCount)
                {
                    double averagePerPresentation = grades / gradeCount;

                    Console.WriteLine($"{presentationType} - {averagePerPresentation:F2}.");

                    totalGradeCount += gradeCount;

                    grades = 0;

                    gradeCount = 0;

                    presentationType = Console.ReadLine();
                }
            }
        }
    }
}
