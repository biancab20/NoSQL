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
            string[] searchWords = searchQuery.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<Ticket> filteredTickets = allTickets
                .Where(ticket => IsTicketVisible(ticket, searchWords, userRole, currentUsername))
                .OrderByDescending(ticket => ticket.DeadlineFollowUp)
                .ToList();

            return filteredTickets;
        }

        private bool IsTicketVisible(Ticket ticket, string[] searchWords, string userRole, string currentUsername)
        {
            if (ticket != null && ticket.Subject != null)
            {
                bool matchesSearch = searchWords.All(word =>
                    ticket.Subject.ToLower().Contains(word) || ticket.Description.ToLower().Contains(word)
                );

                if (userRole == "ServiceDesk" || (userRole == "Other" && ticket.ReportedByUser == currentUsername))
                {
                    return matchesSearch;
                }
            }

            return false;
        }
    }
}
