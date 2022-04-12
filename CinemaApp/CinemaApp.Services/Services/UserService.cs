using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Services.Services
{
    public class UserService : IUserService
    {
        public Guid AddUser(UserDto user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDtoId> GetAllUsers(string userRole)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDtoId> SearchUsers(string username, string userRole)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Guid id, UserDto client)
        {
            throw new NotImplementedException();
        }
    }
}
