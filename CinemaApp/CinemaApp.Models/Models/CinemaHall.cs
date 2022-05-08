using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Models.Models
{
    public class CinemaHall
    {
        public CinemaHall(Guid id, string name, int nmbrOfSeats)
        {
            Id = id;
            Name = name;
            NmbrOfSeats = nmbrOfSeats;
        }
        public Guid Id { get; }
        public string Name { get; }
        public int NmbrOfSeats { get; }
    }
}
