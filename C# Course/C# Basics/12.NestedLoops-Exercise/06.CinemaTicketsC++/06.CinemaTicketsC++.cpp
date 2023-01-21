#include <iostream>
#include <string>
#include <iomanip>
#include <math.h>

using namespace std;

int main()
{
    string movieName;
    cin >> movieName;

    int studentTickets = 0;

    int standardTickets = 0;

    int kidTickets = 0;

    while (movieName != "Finish")
    {
        int freeSeats;
        cin >> freeSeats;

        int takenSeats = 0;

        for (int i = 0; i < freeSeats; i++)
        {
            string ticketType;
            cin >> ticketType;

            if (ticketType == "End")
            {
                break;
            }

            else if (ticketType == "student")
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

            takenSeats++;
        }

        double projectionPercentage = 100.0 * takenSeats / freeSeats;

        cout << movieName << " - " << fixed << setprecision(2) << projectionPercentage << "% full." << "\n";

        getline(cin >> ws, movieName);
    }
    
        int totalTicketsCount = studentTickets + standardTickets + kidTickets;
        cout << "Total tickets: " << totalTicketsCount << "\n";

        double studentPercentage = 100.0 * studentTickets / totalTicketsCount;
        cout << fixed << setprecision(2) << studentPercentage << "% student tickets." << "\n";

        double standardPercentage = 100.0 * standardTickets / totalTicketsCount;
        cout << fixed << setprecision(2) << standardPercentage << "% standard tickets." << "\n";

        double kidPercentage = 100.0 * kidTickets / totalTicketsCount;
        cout << fixed << setprecision(2) << kidPercentage << "% kids tickets." << "\n";

    return 0;
}