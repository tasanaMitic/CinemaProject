using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Common.Interfaces
{
    public interface ICinemaHallRepository
    {
        void AddCinemaHall(CinemaHall cinemaHall);
        IEnumerable<CinemaHall> GetAllCinemaHalls();
        bool DeleteCinemaHall(Guid id);
        CinemaHall GetCinemaHall(Guid id);
    }
}
