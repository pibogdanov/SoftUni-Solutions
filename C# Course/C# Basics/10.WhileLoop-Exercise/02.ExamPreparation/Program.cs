using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfAllowedFailedExams = int.Parse(Console.ReadLine());

            string exam = Console.ReadLine();

            int numberOfExams = 0;

            int numberOfFailedExams = 0;

            double sumGrade = 0;

            string nameOfLastExam = "";

            while (numberOfFailedExams < numberOfAllowedFailedExams)
            {
                if (exam == "Enough")
                {
                    break;
                }

                double grade = double.Parse(Console.ReadLine());

                if ( (2.00 <= grade) && (grade <= 4.00) )
                {
                    numberOfFailedExams++;
                }

                sumGrade += grade;

                numberOfExams++;

                nameOfLastExam = exam;

                exam = Console.ReadLine();
            }

            if (exam == "Enough")
            {
                double avgGrade = sumGrade / numberOfExams;
                Console.WriteLine($"Average score: {avgGrade:F2}");
                Console.WriteLine($"Number of problems: {numberOfExams}");
                Console.WriteLine($"Last problem: {nameOfLastExam}");
            }

            else
            {
                Console.WriteLine($"You need a break, {numberOfFailedExams} poor grades.");
            }
        }
    }
}
