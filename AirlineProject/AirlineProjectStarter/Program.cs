using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineProject;

namespace AirlineProjectStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadeBase FB = new FacadeBase();

            Ticket tk = new Ticket(5, 2, 1);
            Ticket tk2 = new Ticket(5, 1, 1);

            Console.WriteLine("getting all tickets:");
            List<Ticket> tickets = FB.GetAllTickets();
            tickets.ForEach(t => Console.WriteLine(t));
            Console.WriteLine("");

            Console.WriteLine("adding ticket with id - 5, flight id - 2, customer id - 1");
            FB.AddTicket(tk);
            Console.WriteLine("");

            Console.WriteLine("Getting ticket with id of 5:");
            Console.WriteLine(FB.GetTicket(5));
            Console.WriteLine("");

            Console.WriteLine("getting all tickets:");
            tickets = FB.GetAllTickets();
            tickets.ForEach(t => Console.WriteLine(t));
            Console.WriteLine("");

            Console.WriteLine("updating ticket with id - 5, flight id - 2 => 1");
            FB.UpdateTicket(tk2);
            Console.WriteLine("");

            Console.WriteLine("Getting ticket with id of 5:");
            Console.WriteLine(FB.GetTicket(5));
            Console.WriteLine("");

            Console.WriteLine("getting all tickets:");
            tickets = FB.GetAllTickets();
            tickets.ForEach(t => Console.WriteLine(t));
            Console.WriteLine("");

            Console.WriteLine("removing ticket with id - 5:");
            FB.RemoveTicket(tk2);
            Console.WriteLine("");

            Console.WriteLine("getting all tickets:");
            tickets = FB.GetAllTickets();
            tickets.ForEach(t => Console.WriteLine(t));
            Console.WriteLine("");
        }
    }
}
