﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Driver;

namespace Logic
{
    public class TicketService
    {
        TicketDAO ticketDAO;

        public TicketService()
        {
            ticketDAO = new TicketDAO();
        }

        public List<Ticket> GetAllTicket()
        {
            return ticketDAO.GetAllTicket();
        }

        public void CreateTicket(Ticket ticket)
        {
            ticketDAO.CreateTicket(ticket);
        }

        public List<Ticket> GetTicketsByUserId(string userId)
        {
            return GetAllTicket().Where(ticket => ticket.AssignedUserId == userId).ToList();
        }

        public Ticket GetTicketByUserId(string userId)
        {
            return GetAllTicket().FirstOrDefault(ticket => ticket.AssignedUserId == userId);
        }

        public bool DeleteTicket(string ticketId) 
        {
            return ticketDAO.DeleteTicket(ticketId);
        }

        public void UpdateTicket(string ticketId, UpdateDefinition<Ticket> updateDefinition) 
        {
            ticketDAO.UpdateTicket(ticketId, updateDefinition);
        }
    }
}
