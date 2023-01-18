using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examOfHour = int.Parse(Console.ReadLine());

            int minuteOfExam = int.Parse(Console.ReadLine());

            int hourOfArrival = int.Parse(Console.ReadLine());

            int minuteofArrival = int.Parse(Console.ReadLine());

            int examTime = examOfHour * 60 + minuteOfExam;

            int arrivalTime = hourOfArrival * 60 + minuteofArrival;

            int difference = examTime - arrivalTime;

            int hours = Math.Abs(difference / 60);

            int minutes = Math.Abs(difference % 60);

            if (difference < 0)
            {
                Console.WriteLine("Late");

                if (difference < - 59)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }

                else
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
            }

            else if (difference > 30)
            {
                Console.WriteLine("Early");

                if (difference > 59)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }

                else
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }

            else
            {
                Console.WriteLine("On time");

                if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
        }
    }
}
