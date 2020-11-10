
using Microsoft.Extensions.Options;
using School.Common.Auth;
using School.Common.Contracts.Identity;
using School.Contract.Requests.Access_Control.Identity;
using School.Contract.Response.Access_Control.Identity;
using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models;
using Schools.Domain.Models.Access_Control;
using Schools.Domain.Repositories.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace School.Service.Access_Control
{
    public class IdentityService : IIdentityService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtHandler _tokenFactory;
        private readonly IEncrypter _encrypter;
        private readonly IRefreshTokenRepository _refreshTokenRepository;

        public IdentityService(IUserRepository userRepository, IJwtHandler tokenFactory,
            IEncrypter encrypter, IRefreshTokenRepository refreshTokenRepository)
        {
            _userRepository = userRepository;
            _tokenFactory = tokenFactory;
            _encrypter = encrypter;
            _refreshTokenRepository = refreshTokenRepository;
        }
        public bool ChangePassword(ChangePasswordRequest req)
        {
            var user = _userRepository.FindByKey(req.Id);
           // var changed = user.ChangePassword(req.OldPassword, req.NewPassword, _encrypter);
            _userRepository.Save();
            return true;

        }

        public JwtToken IssueJwtToken(string id = "", string email = "", string refresh_token = "")
        {
            var user = new User();
            if (id == String.Empty)
                user = _userRepository.FindBy(a => a.Email == email).FirstOrDefault();
            else
                user = _userRepository.FindByKey(Guid.Parse(id));

            JwtToken token = _tokenFactory.Create(user.Id);
            //var refreshToken = new RefreshToken(token);
            //_refreshTokenRepository.Add(refreshToken);

            //if (refresh_token == "")
            //    token.RefreshToken = refreshToken.Refresh_Token;
            //token.RefreshToken = refresh_token;


            return token;
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
            var user = _userRepository.FindByKey(req.Id);
            user.SetLastConnexion();
            _userRepository.Save();
        }

        public bool RefresToken(RefreshTokenRequest req, out Guid userId)
        {
            bool refreshed = false;
            var refreshToken = _refreshTokenRepository.Get(req.RefreshToken);
            Guid _userId = Guid.Empty;
            if (refreshToken != null)
            {
                _userId = refreshToken.UserId;
                if (!(refreshToken.ExpiryDate <= DateTime.UtcNow))
                {
                    if (!refreshToken.Used)
                        refreshToken.Used = true;
                    else refreshToken.Used = true;
                    _refreshTokenRepository.Refresh(refreshToken);
                }

            }
            userId = _userId;
            return refreshed;
        }
    }
}
