using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;

namespace DAL
{
    public class DAO
    {
        private IMongoClient client;
        private IMongoDatabase database;
        public DAO()
        {
            client = new MongoClient("mongodb+srv://user1:user12345@cluster0.wmykyq2.mongodb.net/");
            database = client.GetDatabase("TheGardenGroupDatabase");

        }
        public IMongoCollection<User> users => database.GetCollection<User>("User");
        public IMongoCollection<Ticket> tickets => database.GetCollection<Ticket>("Ticket");

    }


}
