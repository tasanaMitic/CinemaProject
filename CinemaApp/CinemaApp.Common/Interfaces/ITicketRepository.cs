using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;

namespace CinemaApp.Common.Interfaces
{
    public interface ITicketRepository
    {
        void BuyTicket(Ticket ticket);
        IEnumerable<Ticket> GetTickets(string projection); //or username
        bool DeleteTicket(Guid id);
    }
}
