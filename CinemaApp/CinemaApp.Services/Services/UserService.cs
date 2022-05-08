using CinemaApp.Common.Dtos;
using CinemaApp.Common.Interfaces;
using CinemaApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaApp.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Guid AddUser(UserDto userDto)
        {
            Guid id = Guid.NewGuid();
            _userRepository.AddUser(new User(userDto.Username, userDto.Name, userDto.Password, userDto.Email, userDto.Role, id));
            return id;
        }

        public bool DeleteUser(Guid id)
        {
            return _userRepository.DeleteUser(id);
        }

        public IEnumerable<UserDtoId> GetAllUsers(string userRole)
        {
            return MapUserListToUserDtoIdList(_userRepository.GetAllUsers(userRole));
        }

        public IEnumerable<UserDtoId> SearchUsers(string username, string userRole)
        {
            return MapUserListToUserDtoIdList(_userRepository.SearchUsers(username, userRole));
        }

        public void UpdateUser(Guid id, UserDto userDto)
        {
            var user = new User(userDto.Username, userDto.Name, userDto.Password, userDto.Email, userDto.Role, id);
            _userRepository.UpdateUser(id, user);
        }

        private IEnumerable<UserDtoId> MapUserListToUserDtoIdList(IEnumerable<User> users)
        {
            return users.Select(x => new UserDtoId() { Name = x.Name, Username = x.Username, Password = x.Password, Email = x.Email, Role = x.Role.ToString(), Id = x.Id });
        }
    }
}
