using CinemaApp.Common.Interfaces;
using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;

namespace CinemaApp.Repositories.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        public void AddFilm(Film film)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFilm(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> SearchFilms(string criteria)
        {
            throw new NotImplementedException();
        }
    }
}
