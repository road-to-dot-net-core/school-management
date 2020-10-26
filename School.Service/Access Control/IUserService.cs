using School.Contract.Requests.Users;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public interface IUserService
    {
        bool Insert(RegisterUserRequest user);
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        bool DoesUseHaveAccessTo(Guid userId, string actionName);
    }
}
