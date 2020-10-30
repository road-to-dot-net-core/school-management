using School.Common.Auth;
using School.Contract.Requests.Users;
using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEncrypter _encrypter;

        public UserService(IUserRepository userRepository, IEncrypter encrypter)
        {
            _userRepository = userRepository;
            _encrypter = encrypter;
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

        public bool Insert(RegisterUserRequest req)
        {
            var user = new User(req.FirstName, req.LastName, req.Password, req.Email, req.RoleId, req.CreatedBy, _encrypter);
            _userRepository.Insert(user);
            return _userRepository.Save();

        }

    }
}
