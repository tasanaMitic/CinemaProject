using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaApp.Services.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IUserRepository _userRepository;
        private readonly IProjectionRepository _projectionRepository;
        public TicketService(ITicketRepository ticketRepository, IUserRepository userRepository, IProjectionRepository projectionRepository)
        {
            _ticketRepository = ticketRepository;
            _userRepository = userRepository;
            _projectionRepository = projectionRepository;
        }
        public Guid BuyTicket(TicketDto ticketDto)
        {
            Guid id = new Guid();
            User user = _userRepository.GetUser(ticketDto.Username);
            Projection projection = _projectionRepository.GetProjection(ticketDto.ProjectionId);
            _ticketRepository.BuyTicket(new Ticket(id, ticketDto.Number, ticketDto.Price, true, user, projection));
            return id;
        }

        public bool DeleteTicket(Guid id)
        {
            return _ticketRepository.DeleteTicket(id);
        }

        public IEnumerable<TicketDtoId> GetTickets(string projection)
        {
            return _ticketRepository.GetTickets(projection).Select(x => new TicketDtoId() { Number = x.Number, Price = x.Price, Sold = x.Sold, TicketId = x.Id, ProjectionId = x.Projection.Id, Username = x.User.Username });
        }
    }
}
