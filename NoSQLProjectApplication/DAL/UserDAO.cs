using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MongoDB.Bson;
using System.Security.Cryptography;

namespace DAL
{
    public class UserDAO : DAO
    {

        private IMongoClient client;
        private IMongoDatabase database;
        private IMongoCollection<User> collection;

        public UserDAO()
        {
            client = new MongoClient("mongodb+srv://user1:user12345@cluster0.wmykyq2.mongodb.net/");
            database = client.GetDatabase("TheGardenGroupDatabase");
            collection = database.GetCollection<User>("User");
        }
       
        public List<User> GetAllUsers()
        {
            return users.Find(_ => true).ToList();
        }
        public void CreateUser(User user)
        {
            users.InsertOne(user);
        }
        public void UpdateUser(string userId, UpdateDefinition<User> updateDefinition)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Id, new ObjectId(userId));
            users.UpdateOne(filter, updateDefinition);
        }
        public void DeleteUser(string userId)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Id, new ObjectId(userId));
            users.DeleteOne(filter);
        }
        public string Hash(string password)
        {
            var sha = SHA256.Create();

            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);

            return Convert.ToBase64String(hashedPassword);
        }
        public User GetUserByUserName(string username)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Username, username);
            return users.Find(filter).FirstOrDefault();
        }
        public User GetUserByPassword(string password)
        {
            // Hash the provided passcode to match it with the stored hashed password.
            string hashedPasscode = Hash(password);

            var filter = Builders<User>.Filter.Eq(u => u.Password, hashedPasscode);
            return users.Find(filter).FirstOrDefault();
        }
    }
}
