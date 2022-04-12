using CinemaApp.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Common.Interfaces
{
    public interface IUserService
    {
        Guid AddUser(UserDto user);
        IEnumerable<UserDtoId> GetAllUsers(string userRole);
        IEnumerable<UserDtoId> SearchUsers(string username, string userRole);
        bool DeleteUser(Guid id);
        void UpdateUser(Guid id, UserDto client);
    }
}
