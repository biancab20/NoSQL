using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class TicketDAO : DAO
    {
        public List<Ticket> GetAllTickets()
        {
            //Find with an empty filter (true) to retrieve all documents in the collection
            return tickets.Find(_ => true).ToList();
        }

        public void CreateTicket(Ticket ticket)
        {
            tickets.InsertOne(ticket);
        }
    }
}
