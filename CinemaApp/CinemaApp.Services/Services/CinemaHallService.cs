using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaApp.Services.Services
{
    public class CinemaHallService : ICinemaHallService
    {
        private readonly ICinemaHallRepository _cinemaHallRepository;
        public CinemaHallService(ICinemaHallRepository cinemaHallRepository)
        {
            _cinemaHallRepository = cinemaHallRepository;
        }
        public Guid AddCinemaHall(CinemaHallDto cinemaHallDto)
        {
            Guid id = new Guid();
            _cinemaHallRepository.AddCinemaHall(new CinemaHall(id, cinemaHallDto.Name, cinemaHallDto.NumberOfSeats));
            return id;
        }

        public bool DeleteCinemaHall(Guid id)
        {
            return _cinemaHallRepository.DeleteCinemaHall(id);
        }

        public IEnumerable<CinemaHallDtoId> GetAllCinemaHalls()
        {
            return _cinemaHallRepository.GetAllCinemaHalls().Select(x => new CinemaHallDtoId() { Name = x.Name, NumberOfSeats = x.NmbrOfSeats, CinemaHallId = x.Id });
        }
    }
}
