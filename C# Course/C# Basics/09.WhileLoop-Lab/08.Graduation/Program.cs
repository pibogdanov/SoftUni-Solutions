using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;

            int badGrades = 0;

            double allGrades = 0;

            while (grade < 13)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade >= 4.00 && currentGrade <= 6.00)
                {
                    grade++;

                    allGrades += currentGrade;
                }

                else if (currentGrade >= 2.00)
                {
                    badGrades++;

                    if (badGrades > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");

                        return;
                    }

                }
            }

            double avgGrade = allGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {avgGrade:F2}");
        }
    }
}
