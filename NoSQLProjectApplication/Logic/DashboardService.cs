using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class DashboardService
    {
        private readonly TicketDAO ticketDAO;

        public DashboardService()
        {
            ticketDAO = new TicketDAO();
        }
    
        public Dictionary<string, double> GetTicketStatusPercentages()
        {
            List<Ticket> tickets = ticketDAO.GetAllTickets();
           
            // Calculate percentages for different ticket statuses
            Dictionary<string, double> statusPercentages = new Dictionary<string, double>
            {
                { TicketStatus.Unresolved.ToString(), CalculateStatusPercentage(tickets, TicketStatus.Unresolved) },
                { TicketStatus.InProgress.ToString(), CalculateStatusPercentage(tickets, TicketStatus.InProgress) },
                { TicketStatus.Solved.ToString(), CalculateStatusPercentage(tickets, TicketStatus.Solved) },               
            };

            return statusPercentages;
        }

        private double CalculateStatusPercentage(List<Ticket> tickets, TicketStatus status)
        {
            int totalTickets = tickets.Count;
            int statusCount = tickets.Count(t => t.Status == status);

            return (double)statusCount / totalTickets * 100.0;
        }

    }
}
