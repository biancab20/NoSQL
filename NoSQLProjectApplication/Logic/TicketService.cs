using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Driver;

namespace Logic
{
    public class TicketService
    {
        TicketDAO ticketDAO;

        public TicketService()
        {
            ticketDAO = new TicketDAO();
        }

        public List<Ticket> GetAllTickets()
        {
            return ticketDAO.GetAllTickets();
        }

        //public int GetNewTicketId()
        //{ 
        //    return ticketDAO.GetNewTicketId();
        //}

        public void CreateTicket(Ticket ticket)
        {
            ticketDAO.CreateTicket(ticket);
        }
    }
}
