﻿using System;
using System.Collections.Generic;
using System.Data;
using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _filmService;
        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpPost]
        public ActionResult<FilmDto> AddFilm(FilmDto film)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                Guid filmId = _filmService.AddFilm(film);
                return CreatedAtAction("AddFilm", new { Id = filmId }, film);
            }
            catch (ArgumentException e)
            {
                return BadRequest();
            }
            catch (DuplicateNameException e)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        public ActionResult<IEnumerable<FilmDtoId>> GetAllFilms()
        {
            return Ok(_filmService.GetAllFilms());
        }

        [HttpGet]
        public ActionResult<IEnumerable<FilmDtoId>> SearchFilms(string criteria)
        {
            return Ok(_filmService.SearchFilms(criteria));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFilm(Guid id)
        {
            return _filmService.DeleteFilm(id) ? (IActionResult)NoContent() : NotFound();
        }
    }
}