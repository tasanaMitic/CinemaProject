using CinemaApp.Common.Dtos;
using System;
using System.Collections.Generic;

namespace CinemaApp.Common.Interfaces
{
    public interface ICinemaHallService
    {
        Guid AddCinemaHall(CinemaHallDto cinemaHall);
        IEnumerable<CinemaHallDtoId> GetAllCinemaHalls();
        bool DeleteCinemaHall(Guid id);
    }
}
