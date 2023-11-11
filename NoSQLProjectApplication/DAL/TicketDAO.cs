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
        private IMongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<Ticket> collection;

        public TicketDAO()
        {
            client = new MongoClient("mongodb+srv://user1:user12345@cluster0.wmykyq2.mongodb.net/");
            database = client.GetDatabase("TheGardenGroupDatabase");
            collection = database.GetCollection<Ticket>("Ticket");
        }

        public List<Ticket> GetAllTickets()
        {
            //Find with an empty filter (true) to retrieve all documents in the collection
            return tickets.Find(_ => true).ToList();
        }

        public List<Ticket> GetAllTicket()
        {
            // Projection to specify the deserialization for enum properties
            var projectionDefinition = Builders<Ticket>.Projection
                .Expression(ticket => new Ticket
                {
                    ObjectId = ticket.ObjectId,
                    DateTimeReported = ticket.DateTimeReported,
                    Subject = ticket.Subject,
                    IncidentType = ticket.IncidentType,
                    ReportedByUser = ticket.ReportedByUser,
                    Priority = ticket.Priority,
                    DeadlineFollowUp = ticket.DeadlineFollowUp,
                    Description = ticket.Description,
                    Status = ticket.Status
                });

            // Retrieve all documents in the collection, applying the projection
            return tickets.Find(_ => true)
                .Project<Ticket>(projectionDefinition)
                .ToList();
        }

        public void CreateTicket(Ticket ticket)
        {
            tickets.InsertOne(ticket);
        }

        public void UpdateTicket(string ticketId, UpdateDefinition<Ticket> updateDefinition)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ObjectId, new ObjectId(ticketId));
            tickets.UpdateOne(filter, updateDefinition);
        }

        public void DeleteTicket(string ticketId)
        {
            var filter = Builders<Ticket>.Filter.Eq(t => t.ObjectId, new ObjectId(ticketId));
            tickets.DeleteOne(filter);
        }
    }
}
