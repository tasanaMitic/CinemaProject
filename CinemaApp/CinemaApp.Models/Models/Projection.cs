using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Models.Models
{
    public class Projection
    {
        public Projection(Guid id, DateTime date, string time, bool soldOut, Film film, CinemaHall cinemaHall)
        {
            Id = id;
            Date = date;
            Time = time;
            SoldOut = soldOut;
            Film = film;
            CinemaHall = cinemaHall;

        }
        public Guid Id { get; }
        public DateTime Date { get; }
        public string Time { get; }
        public bool SoldOut { get; }
        public Film Film { get; }
        public CinemaHall CinemaHall { get; }

    }
}
