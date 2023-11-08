using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("first_name")]
        public string FirstName { get; set; }
        [BsonElement("last_name")]
        public string LastName { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("username")]
        public string Username { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
        [BsonElement("role")]
        public Role Role { get; set; }

        [BsonElement("ticket")]
        public int Ticket { get; set; }

       
    }
}
