using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Common.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetAllUsers(string userRole);
        IEnumerable<User> SearchUsers(string username, string userRole);
        bool DeleteUser(Guid id);
        void UpdateUser(Guid id, User client);
        User GetUser(string username);
    }
}
