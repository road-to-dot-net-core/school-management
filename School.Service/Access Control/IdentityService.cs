
using CSharpFunctionalExtensions;
using School.Common.Auth;
using School.Common.Contracts.Identity;
using School.Contract.Requests.Access_Control.Identity;
using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models;
using Schools.Domain.Models.Access_Control;
using Schools.Domain.Repositories.Access_Control;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace School.Service.Access_Control
{
    public class IdentityService : IIdentityService
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtHandler _jwtHandler;
        private readonly IRefreshTokenRepository _refreshTokenRepository;

        public IdentityService(IUserRepository userRepository, IJwtHandler tokenFactory,
                               IRefreshTokenRepository refreshTokenRepository)
        {
            _userRepository = userRepository;
            _jwtHandler = tokenFactory;
            _refreshTokenRepository = refreshTokenRepository;
        }
        public Result ChangePassword(ChangePasswordRequest req)
        {
            Result<Password> newPasswOrdResult = Password.Create(req.NewPassword);
            Result<Password> oldPasswordResult = Password.Create(req.OldPassword);

            var user = _userRepository.FindByKey(req.Id);

            if (oldPasswordResult.IsFailure)
                return Result.Failure($"Password invalid ");

            if (user.Password != oldPasswordResult.Value)
                return Result.Failure($"Incorrect password");

            user.ChangePassword(newPasswOrdResult.Value);
            _userRepository.Save();

            return Result.Success();

        }

        public JwtToken IssueJwtToken(string id = "", string email = "")
        {
            var user = new User();
            Guid userId = Guid.Empty;

            if (id == String.Empty)
            {
                user = _userRepository.FindBy(a => a.Email == email).FirstOrDefault();
                userId = user.Id;
            }
            else userId = Guid.Parse(id);

            JwtToken token = _jwtHandler.Create(userId);
            var refreshToken = new RefreshToken(token);
            _refreshTokenRepository.Add(refreshToken);

            return token;
        }

        public bool Authenticate(LoginRequest req)
        {
            var user = _userRepository.FindBy(a => a.Email == req.Login).FirstOrDefault();
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

        public Result RefresToken(RefreshTokenRequest req, out Guid userId)
        {
            Result refreshResult = Result.Success();
            Guid _userId = Guid.Empty;

            var validatedToken = _jwtHandler.GetValidPrincipalClaim(req.Token);

            if (validatedToken == null)
            {
                userId = _userId;
                return Result.Failure("Invalid Token");
            }

            var expiryDateInseconds =
                long.Parse(validatedToken.Claims.Single(x => x.Type == JwtRegisteredClaimNames.Exp).Value);

            var expiryDateTimeUtc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            expiryDateTimeUtc = expiryDateTimeUtc.AddSeconds(expiryDateInseconds);

            if (expiryDateTimeUtc > DateTime.UtcNow)
            {
                userId = _userId;
                return Result.Failure("This token hasn't expired yet");
            }

            var jti = validatedToken.Claims.Single(x => x.Type == JwtRegisteredClaimNames.Jti).Value;

            var storedRefreshToken = _refreshTokenRepository.Get(req.RefreshToken);


            if (storedRefreshToken == null)
            {
                userId = _userId;
                return Result.Failure("This refresh token does not exist");
            }

            if (DateTime.UtcNow > storedRefreshToken.ExpiryDate)
            {
                userId = _userId;
                return Result.Failure("This refresh token has expired");
            }

            if (storedRefreshToken.Invalidated)
            {
                userId = _userId;
                return Result.Failure("This refresh token has been invalidated");
            }

            if (storedRefreshToken.Used)
            {
                userId = _userId;
                return Result.Failure("This refresh token has been used");

            }

            if (storedRefreshToken.JwtId != jti)
            {
                userId = _userId;
                return Result.Failure("This refresh token does not match this JWT");
            }

            storedRefreshToken.Used = true;
            _refreshTokenRepository.Refresh(storedRefreshToken);

            _userId = Guid.Parse(validatedToken.Claims.Single(x => x.Type == "id").Value);


            userId = _userId;
            return refreshResult;
        }
    }
}
