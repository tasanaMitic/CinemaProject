using System;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public ActionResult<UserDto> AddUser(UserDto user)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                Guid userId = _userService.AddUser(user);
                return CreatedAtAction("AddUser", new { Id = userId }, user);
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
        public ActionResult<IEnumerable<UserDtoId>> GetAllUsers(string userRole)
        {
            return Ok(_userService.GetAllUsers(userRole));
        }

        [HttpGet("{username}")]
        public ActionResult<IEnumerable<UserDtoId>> SearchUsers(string username, string userRole)
        {
            return Ok(_userService.SearchUsers(username, userRole));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            return _userService.DeleteUser(id) ? (IActionResult)NoContent() : NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, UserDto user)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _userService.UpdateUser(id, user);
                return NoContent();
            }
            catch (KeyNotFoundException e)
            {
                return NotFound();
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

    }
}
