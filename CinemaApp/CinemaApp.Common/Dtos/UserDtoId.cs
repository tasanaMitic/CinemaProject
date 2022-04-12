using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Common.Dtos
{
    public class UserDtoId : UserDto
    {
        Guid UserId { get; set; }
    }
}
