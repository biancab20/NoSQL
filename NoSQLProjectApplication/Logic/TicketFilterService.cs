using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class TicketFilterService
    {
        private List<Ticket> allTickets;

        public TicketFilterService(List<Ticket> tickets)
        {
            allTickets = tickets ?? new List<Ticket>();
        }

        public List<Ticket> FilterTickets(string searchQuery, string userRole, string currentUsername)
        {

            string[] searchWords = searchQuery.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return allTickets
                .Where(ticket => IsTicketVisible(ticket, searchWords, userRole, currentUsername))
                .OrderByDescending(ticket => ticket.DeadlineFollowUp)
                .ToList();

        }

        private bool IsTicketVisible(Ticket ticket, string[] searchWords, string userRole, string currentUsername)
        {
            if (ticket == null)
            {
                return false;
            }

            bool matchesSearch = searchWords.Any(word =>
                (ticket.Subject != null && ticket.Subject.ToLower().Contains(word)) ||
                (ticket.Description != null && ticket.Description.ToLower().Contains(word)) ||
                (ticket.ReportedByUser != null && ticket.ReportedByUser.ToLower().Contains(word)) ||
                ticket.Priority.ToString().ToLower().Contains(word) || 
                ticket.Status.ToString().ToLower().Contains(word)    
            );

         
            if (userRole == "ServiceDesk")
            {
                return matchesSearch;
            }

            return matchesSearch && ticket.ReportedByUser.Equals(currentUsername, StringComparison.OrdinalIgnoreCase);
        }
    }
}
