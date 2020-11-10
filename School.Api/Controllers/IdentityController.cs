using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using School.Api.Filters;
using School.Common.Auth;
using School.Common.Contracts.Identity;
using School.Contract.Requests.Access_Control.Identity;
using School.Contract.Response.Access_Control.Identity;
using School.Service.Access_Control;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace School.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]

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
            var token = _identityService.IssueJwtToken("", req.Email);

            return Ok(token);

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
            bool refreshed = _identityService.RefresToken(req,out userId);

            if(refreshed)
            {
                var token = _identityService.IssueJwtToken(userId.ToString(),"",req.RefreshToken);

                return Ok(token);
            }
            else
            {
                return BadRequest(new AuthFailedResponse { Errors = new[] { "Refresh Token Incorrect" } });
            }

        }

        [HttpPost("changePassword")]
        public IActionResult ChangePassword(ChangePasswordRequest req)
        {

            bool changed = _identityService.ChangePassword(req);
            if (!changed)
            {
                return BadRequest(new AuthFailedResponse { Errors = new[] { "Incorrect password " } });
            }

            return Ok();
        }


    }
}
