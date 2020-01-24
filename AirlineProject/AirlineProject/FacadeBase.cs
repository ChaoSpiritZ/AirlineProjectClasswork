using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    public class FacadeBase
    {
        private TicketDAOMSSQL TicketDAO = new TicketDAOMSSQL();

        public void AddTicket(Ticket ticket)
        {
            TicketDAO.Add(ticket);
        }

        public Ticket GetTicket(int id)
        {
            Ticket ticket = TicketDAO.Get(id);
            return ticket;
        }

        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = TicketDAO.GetAll();
            return tickets;
        }

        public void RemoveTicket(Ticket ticket)
        {
            TicketDAO.Remove(ticket);
        }

        public void UpdateTicket(Ticket ticket)
        {
            TicketDAO.Update(ticket);
        }
    }
}
