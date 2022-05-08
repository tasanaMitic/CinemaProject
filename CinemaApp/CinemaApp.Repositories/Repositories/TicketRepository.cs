using CinemaApp.Common.Interfaces;
using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;

namespace CinemaApp.Repositories.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        public void BuyTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTicket(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ticket> GetTickets(string projection)
        {
            throw new NotImplementedException();
        }
    }
}
