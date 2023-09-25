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
            client = new MongoClient("mongodb+srv://user2:12345@cluster0.jfozv.mongodb.net/DemoChart?retryWrites=true&w=majority");
        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }
    }


}
