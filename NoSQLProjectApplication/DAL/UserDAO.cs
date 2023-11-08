using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class UserDAO : DAO
    {
        public List<User> GetAllUsers()
        {
            var filter = Builders<User>.Filter.Empty;
            var users = userCollection.Find(filter).ToList();
            return users();
        }
    }
}
