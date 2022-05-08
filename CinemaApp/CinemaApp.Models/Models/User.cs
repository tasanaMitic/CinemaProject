using CinemaApp.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Models.Models
{
    public class User
    {
        public User(string username, string name, string password, string email, string role, Guid id)
        {
            Name = name;
            Username = username;
            Password = password;
            Email = email;
            Id = id;

            switch (role)
            {
                case("ADMIN"):
                    Role = RoleType.ADMIN;
                    break;
                case("USER"):
                    Role = RoleType.USER;
                    break;
                case ("EPLOYEE"):
                    Role = RoleType.EPLOYEE;
                    break;
                default:
                    throw new ArgumentException("Role value not correct!");
            }
        }
        public Guid Id { get; }
        public string Username { get; }
        public string Name { get;}
        public string Password { get; }
        public string Email { get; }
        public RoleType Role { get; }
    }
}
