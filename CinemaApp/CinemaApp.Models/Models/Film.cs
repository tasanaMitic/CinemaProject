using CinemaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaApp.Models.Models
{
    public class Film
    {
        public Film(Guid id, string name, string director, IEnumerable<string> genre, int duration, int releaseYear)
        {
            Id = id;
            Name = name;
            Director = director;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre.Select(x => Enum.Parse(typeof(FilmGenre), x))
                            .Cast<FilmGenre>()
                            .ToList();
        }
        public Guid Id { get; }
        public string Name { get; }
        public string Director { get; }
        public IEnumerable<FilmGenre> Genre { get; }
        public int Duration { get; }
        public int ReleaseYear { get; }
    }
}
