using CinemaApp.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Common.Interfaces
{
    public interface IFilmService
    {
        Guid AddFilm(FilmDto filmDto);
        IEnumerable<FilmDtoId> GetAllFilms();
        IEnumerable<FilmDtoId> SearchFilms(string criteria);
        bool DeleteFilm(Guid id);
    }
}
