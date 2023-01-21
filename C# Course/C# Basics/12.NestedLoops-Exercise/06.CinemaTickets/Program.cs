using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName;

            int studentTickets = 0;

            int standardTickets = 0;

            int kidTickets = 0;

            while ( (movieName = Console.ReadLine()) != "Finish" )
            {
                int freeSeats = int.Parse(Console.ReadLine());

                int takenSeats = 0;

                string ticketType;

                while (takenSeats < freeSeats && (ticketType = Console.ReadLine()) != "End")
                {
                    takenSeats++;

                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }

                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }

                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                }

                double projectionPercentage = 100.0 * takenSeats / freeSeats;
                Console.WriteLine($"{movieName} - {projectionPercentage:F2}% full.");
            }

            int totalTicketsCount = studentTickets + standardTickets + kidTickets;
            Console.WriteLine($"Total tickets: {totalTicketsCount}");

            double studentPercentage = 100.0 * studentTickets / totalTicketsCount;
            Console.WriteLine($"{studentPercentage:F2}% student tickets.");

            double standardPercentage = 100.0 * standardTickets / totalTicketsCount;
            Console.WriteLine($"{standardPercentage:F2}% standard tickets.");

            double kidPercentage = 100.0 * kidTickets / totalTicketsCount;
            Console.WriteLine($"{kidPercentage:F2}% kids tickets.");
        }
    }
}
