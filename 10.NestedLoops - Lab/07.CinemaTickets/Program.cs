using System;

namespace _07CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int totalTickets = 0;
            double standartTicket = 0;
            double kidTicket = 0;
            double studentTicket = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                int ticketCounter = 0;
                string ticketType = Console.ReadLine();


                while (ticketType != "End")
                {
                    ticketCounter++;

                    switch (ticketType)
                    {
                        case "standard":
                            standartTicket++;
                            break;
                        case "kid":
                            kidTicket++;
                            break;
                        case "student":
                            studentTicket++;
                            break;
                    }

                    if (ticketCounter == availableSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }

                totalTickets += ticketCounter;

                double percentFull = ticketCounter * 1.0 / availableSeats * 100;
                Console.WriteLine($"{movie} - {percentFull:f2}% full.");
                movie = Console.ReadLine();
            }


            Console.WriteLine($"Total tickets: {totalTickets}");

            double standartTicketsPercent = standartTicket / totalTickets * 100;
            double kidTicketsPercent = kidTicket / totalTickets * 100;
            double studentTicketsPercent = studentTicket / totalTickets * 100;

            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standartTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercent:f2}% kids tickets.");
            


        }
    }
}
