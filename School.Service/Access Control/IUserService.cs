using CSharpFunctionalExtensions;
using School.Contract.Commands.AccessControl.Users;
using School.Contract.Requests.Users;
using School.Contract.Response.Access_Control.Menu;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public interface IUserService
    {
        Result Insert(RegisterUserCommand user);
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        bool DoesUseHaveAccessTo(Guid userId, string actionName);
        UserMenuResponse GetMenu(Guid userId);
    }
}
