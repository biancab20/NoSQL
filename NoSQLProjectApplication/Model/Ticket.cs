using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        [BsonId] public ObjectId ObjectId { get; set; }
        [BsonElement("date_time_reported")] public DateTime DateTimeReported { get; set; }
        [BsonElement("subject")] public string Subject { get; set; }
        // [BsonElement("incident_type")] public IncidentType IncidentType { get; set; }

        [BsonElement("incident_type")]
        [BsonRepresentation(BsonType.String)]
        public IncidentType IncidentType { get; set; }

        [BsonElement("reported_by_user")] public string ReportedByUser { get; set; }
        // [BsonElement("priority")] public Priority Priority { get; set; }
        [BsonElement("priority")]
        [BsonRepresentation(BsonType.String)]
        public Priority Priority { get; set; }
        [BsonElement("deadline_follow_up")] public DateTime DeadlineFollowUp { get; set; }
        [BsonElement("description")] public string Description { get; set; }
       // [BsonElement("status")] public TicketStatus Status { get; set; }

        [BsonElement("status")]
        [BsonRepresentation(BsonType.String)]
        public TicketStatus Status { get; set; }
    }
}
