using System;

namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 2 && grade <= 6)
            {
                CheckGrade(grade);
            }
        }

        static void CheckGrade(double grade) 
        {
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent");
            }

            else if (grade >= 4.5)
            {
                Console.WriteLine("Very good");
            }

            else if (grade >= 3.5)
            {
                Console.WriteLine("Good");
            }

            else if (grade >= 3)
            {
                Console.WriteLine("Poor");
            }

            else if (grade >= 2) 
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
