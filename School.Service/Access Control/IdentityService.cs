
using School.Common.Auth;
using School.Common.Contracts.Identity;
using School.Contract.Requests.Access_Control.Identity;
using School.Contract.Response.Access_Control.Identity;
using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Service.Access_Control
{
    public class IdentityService : IIdentityService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtHandler _jwtHandler;
        private readonly IEncrypter _encrypter;

        public IdentityService(IUserRepository userRepository, IJwtHandler jwtHandler, IEncrypter encrypter)
        {
            _userRepository = userRepository;
            _jwtHandler = jwtHandler;
            _encrypter = encrypter;
        }
        public bool ChangePassword(ChangePasswordRequest req)
        {
            throw new NotImplementedException();
        }

        public JsonWebTokenResponse IssueJwtToken(string id = "", string email = "")
        {
            var user = new User();
            if (id == String.Empty)
                user = _userRepository.FindBy(a => a.Email == email).FirstOrDefault();
            else
                user = _userRepository.FindByKey(Guid.Parse(id));

            JwtToken token = _jwtHandler.Create(user.Id);


            JsonWebTokenResponse tokenResp = new JsonWebTokenResponse { Token = token.Token, Expires = token.Expires };
            return tokenResp;
        }

        public bool Authenticate(LoginRequest req)
        {
            var user = _userRepository.FindBy(a => a.Email == req.Email).FirstOrDefault();
            if (user == null)
                return false;
            //else
            //{
            //    if (!user.VerifyPassword(req.Password, _encrypter))
            //        return false;
            //}
            return true;

        }

        public void LogOut(LogOutRequest req)
        {
            throw new NotImplementedException();
        }

        public JsonWebTokenResponse RefreshToken(RefreshTokenRequest req)
        {
            throw new NotImplementedException();
        }
    }
}
