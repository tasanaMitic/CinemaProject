using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaApp.Services.Services
{
    public class ProjectionService : IProjectionService
    {
        private readonly IProjectionRepository _projectionRepository;
        private readonly IFilmRepository _filmRepository;
        private readonly ICinemaHallRepository _cinemaHallRepository;
        public ProjectionService(IProjectionRepository projectionRepository, IFilmRepository filmRepository, ICinemaHallRepository cinemaHallRepository )
        {
            _projectionRepository = projectionRepository;
            _filmRepository = filmRepository;
            _cinemaHallRepository = cinemaHallRepository;
        }
        public Guid AddProjection(ProjectionDto projectionDto)
        {
            Guid id = new Guid();
            Film film = _filmRepository.GetFilm(projectionDto.FilmId);
            CinemaHall cinemaHall = _cinemaHallRepository.GetCinemaHall(projectionDto.CinemaHallId);
            _projectionRepository.AddProjection(new Projection(id, projectionDto.Date, projectionDto.Time, projectionDto.SoldOut, film, cinemaHall));
            return id;
        }

        public bool DeleteProjection(Guid id)
        {
            return _projectionRepository.DeleteProjection(id);
        }

        public IEnumerable<ProjectionDtoId> GetProjections(string date)
        {
            return _projectionRepository.GetProjections(date).Select(x => new ProjectionDtoId() { ProjectionId = x.Id,
                                                                                                            Date = x.Date,
                                                                                                            Time = x.Time,
                                                                                                            SoldOut = x.SoldOut,
                                                                                                            FilmId = x.Film.Id,
                                                                                                            CinemaHallId = x.CinemaHall.Id });
        }

        public void UpdateProjection(Guid id, ProjectionDto projectionDto)
        {
            Film film = _filmRepository.GetFilm(projectionDto.FilmId);
            CinemaHall cinemaHall = _cinemaHallRepository.GetCinemaHall(projectionDto.CinemaHallId);
            _projectionRepository.UpdateProjection(id, new Projection(id, projectionDto.Date, projectionDto.Time, projectionDto.SoldOut, film, cinemaHall));
        }
    }
}
