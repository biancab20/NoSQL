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
            allTickets = tickets;
        }

        public List<Ticket> FilterTickets(string searchQuery, string userRole, string currentUsername)
        {
            // Split the search query into individual words
            string[] searchWords = searchQuery.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Filter tickets based on search query and user role
            List<Ticket> filteredTickets = allTickets
                .Where(ticket => IsTicketVisible(ticket, searchWords, userRole, currentUsername))
                .OrderByDescending(ticket => ticket.DeadlineFollowUp)
                .ToList();

            return filteredTickets;
        }

        private bool IsTicketVisible(Ticket ticket, string[] searchWords, string userRole, string currentUsername)
        {
            // Check if the ticket is not null and the subject is not null
            if (ticket != null && ticket.Subject != null)
            {
                // Check if the ticket meets the search criteria
                bool matchesSearch = searchWords.All(word =>
                    ticket.Subject.ToLower().Contains(word) || ticket.Description.ToLower().Contains(word)
                );

                // Check if the user has the right to see the ticket based on the role
                if (userRole == "ServiceDesk" || (userRole == "Other" && ticket.ReportedByUser == currentUsername))
                {
                    return matchesSearch;
                }
            }

            return false;
        }
    }
}
