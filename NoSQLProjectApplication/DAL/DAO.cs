using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class DAO
    {
        private MongoClient client;

        public DAO()
        {
            client = new MongoClient("mongodb+srv://user1:user12345@cluster0.wmykyq2.mongodb.net/");
            IMongoDatabase db = client.GetDatabase("TheGardenGroupDatabase");
            IMongoCollection<User> userCollection = db.GetCollection<User>("User");
            IMongoCollection<Ticket> ticketCollection = db.GetCollection<Ticket>("Ticket");
        }

    }


}
