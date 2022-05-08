using CinemaApp.Common.Interfaces;
using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers(string userRole)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> SearchUsers(string username, string userRole)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Guid id, User client)
        {
            throw new NotImplementedException();
        }
    }
}
