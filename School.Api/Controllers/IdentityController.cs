using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using School.Common.Contracts.Identity;
using School.Contract;
using School.Contract.Requests.Access_Control.Identity;
using School.Service.Access_Control;
using System;

namespace School.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {

            _identityService = identityService;
        }

        [HttpPost("login")]
        public IActionResult LogIn(LoginRequest req)
        {
            bool authenticated = _identityService.Authenticate(req);
            if (!authenticated)
            {
                return BadRequest(new AuthFailedResponse { Errors = new[] { "Email Et/Ou password incorrect" } });
            }
            var token = _identityService.IssueJwtToken("", req.Login);

            return Ok(new UserLoginResponse
            {
                RefreshToken = token.RefreshToken,
                Token =  token.Token
            });

        }

        [HttpPost("logout")]

        public IActionResult LogOut(LogOutRequest req)
        {
            _identityService.LogOut(req);
            return Ok();
        }


        [HttpPost("refresh")]

        public IActionResult RefreshToken(RefreshTokenRequest req)
        {
            Guid userId = Guid.Empty;
            Result refreshedResult = _identityService.RefresToken(req, out userId);

            if (refreshedResult.IsSuccess)
            {
                var token = _identityService.IssueJwtToken(userId.ToString());

                return Ok(new
                {
                    RefreshToken = token.RefreshToken,
                    Token =  token.Token
                });
            }
            else
            {
                return BadRequest(new AuthFailedResponse { Errors = new[] { "Refresh Token Incorrect" } });
            }

        }

        [HttpPost("changePassword")]

        public IActionResult ChangePassword(ChangePasswordRequest req)
        {

            Result result = _identityService.ChangePassword(req);
            if (!result.IsSuccess)
            {
                return BadRequest(new AuthFailedResponse { Errors = new[] { "Incorrect password " } });
            }

            return Ok();
        }


    }
}
