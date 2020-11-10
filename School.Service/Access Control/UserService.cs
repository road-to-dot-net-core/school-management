using CSharpFunctionalExtensions;
using School.Common.Auth;
using School.Contract.Commands.AccessControl.Users;
using School.Contract.Requests.Users;
using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool DoesUseHaveAccessTo(Guid userId, string actionName)
        {
            return _userRepository.DoesUserHaveAccessTo(userId, actionName);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _userRepository.FindByKey(id);
        }

        public Result Insert(RegisterUserCommand command)
        {
            Result<Password> passwordResult = Password.Create(command.Password);
            if (passwordResult.IsFailure)
                return Result.Failure($"Email invalid ");


            var user = new User(command.FirstName, command.LastName, passwordResult.Value, command.Email, command.RoleId, command.CreatedBy);
            _userRepository.Insert(user);
            if (_userRepository.Save())
                return Result.Success();
            else return Result.Failure("can not save current user");

        }

    }
}
