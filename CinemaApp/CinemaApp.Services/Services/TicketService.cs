using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using System;
using System.Collections.Generic;

namespace CinemaApp.Services.Services
{
    public class TicketService : ITicketService
    {
        public Guid BuyTicket(TicketDto ticket)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTicket(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TicketDtoId> GetTickets(string projection)
        {
            throw new NotImplementedException();
        }
    }
}
