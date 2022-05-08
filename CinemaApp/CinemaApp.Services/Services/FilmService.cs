using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaApp.Services.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;
        public FilmService(IFilmRepository filmRepository)
        {
            _filmRepository = filmRepository;
        }
        public Guid AddFilm(FilmDto filmDto)
        {
            Guid id = new Guid();
            _filmRepository.AddFilm(new Film(id, filmDto.Name, filmDto.Director, filmDto.Genre, filmDto.Duration, filmDto.ReleaseYear));
            return id;
        }

        public bool DeleteFilm(Guid id)
        {
            return _filmRepository.DeleteFilm(id);
        }

        public IEnumerable<FilmDtoId> GetAllFilms()
        {
            return _filmRepository.GetAllFilms().Select(x => new FilmDtoId() { Name = x.Name, Director = x.Director, Duration = x.Duration, FilmId = x.Id, ReleaseYear = x.ReleaseYear, Genre = x.Genre.Cast<string>().ToList() });
        }

        public IEnumerable<FilmDtoId> SearchFilms(string criteria)
        {
            return _filmRepository.SearchFilms(criteria).Select(x => new FilmDtoId() { Name = x.Name, Director = x.Director, Duration = x.Duration, FilmId = x.Id, ReleaseYear = x.ReleaseYear, Genre = x.Genre.Cast<string>().ToList() });
        }
    }
}
