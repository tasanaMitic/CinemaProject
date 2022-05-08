using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Common.Interfaces
{
    public interface IFilmRepository
    {
        void AddFilm(Film film);
        IEnumerable<Film> GetAllFilms();
        IEnumerable<Film> SearchFilms(string criteria);
        bool DeleteFilm(Guid id);
        Film GetFilm(Guid id);
    }
}
