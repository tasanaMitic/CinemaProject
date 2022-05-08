using CinemaApp.Common.Dtos;
using System;
using System.Collections.Generic;

namespace CinemaApp.Common.Interfaces
{
    public interface ITicketService
    {
        Guid BuyTicket(TicketDto ticketDtp);
        IEnumerable<TicketDtoId> GetTickets(string projection); //or username
        bool DeleteTicket(Guid id);
    }
}
