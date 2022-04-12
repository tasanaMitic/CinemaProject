using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using System;
using System.Collections.Generic;

namespace CinemaApp.Services.Services
{
    public class FilmService : IFilmService
    {
        public Guid AddFilm(FilmDto film)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFilm(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FilmDtoId> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FilmDtoId> SearchFilms(string criteria)
        {
            throw new NotImplementedException();
        }
    }
}
