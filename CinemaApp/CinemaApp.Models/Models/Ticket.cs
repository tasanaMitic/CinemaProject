using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Models.Models
{
    public class Ticket
    {
        public Ticket(Guid id, int number, int price, bool sold, User user, Projection projection)
        {
            Id = id;
            Number = number;
            Price = price;
            Sold = sold;
            User = user;
            Projection = projection;
        }
        public Guid Id { get; }
        public int Number { get; }
        public int Price { get; }
        public bool Sold { get; }
        public User User { get; }
        public Projection Projection { get; }
    }
}
