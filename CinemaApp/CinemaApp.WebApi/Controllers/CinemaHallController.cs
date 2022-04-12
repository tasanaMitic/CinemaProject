﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaHallController : ControllerBase
    {
        private readonly ICinemaHallService _cinemaHallService;
        public CinemaHallController(ICinemaHallService cinemaHallService)
        {
            _cinemaHallService = cinemaHallService;
        }

        [HttpPost]
        public ActionResult<CinemaHallDto> AddCinemaHall(CinemaHallDto cinemaHall)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                Guid cinemaHallId = _cinemaHallService.AddCinemaHall(cinemaHall);
                return CreatedAtAction("AddCinemaHall", new { Id = cinemaHallId }, cinemaHall);
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
        public ActionResult<IEnumerable<CinemaHallDtoId>> GetAllCinemaHalls()
        {
            return Ok(_cinemaHallService.GetAllCinemaHalls());
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCinemaHall(Guid id)
        {
            return _cinemaHallService.DeleteCinemaHall(id) ? (IActionResult)NoContent() : NotFound();
        }
    }
}