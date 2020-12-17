using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using School.Common.Contracts.Identity;
using School.Contract;
using School.Contract.Requests.Access_Control.Identity;
using School.Contract.Results;
using School.Service.Access_Control;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace School.Api.Controllers.V1
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class IdentityController : BaseController
    {
        private readonly IIdentityService _identityService;
        private readonly IApiResult _apiResult;
        public IdentityController(IIdentityService identityService, IApiResult apiResult):base(apiResult)
        {
            _identityService = identityService;
            _apiResult = apiResult;
        }

        [HttpPost("login")]
        public ActionResult LogIn(LoginRequest req)
        {
            try
            {
                bool authenticated = _identityService.Authenticate(req);
                if (!authenticated)
                    return BadRequest(_apiResult.CreateFailureResult(new AuthFailedResponse()));

                var token = _identityService.IssueJwtToken("", req.Login);
                return Ok(_apiResult.CreateSuccessResult(new AuthSuccessResponse()
                {
                    RefreshToken = token.RefreshToken,
                    Token = token.Token
                }));

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
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
                    Token = token.Token
                });
            }
            else
            {
                return BadRequest(new AuthFailedResponse() { InnerErrorMessages = new List<string>() { "Refresh Token Incorrect" } });
            }
        }

        [HttpPost("changePassword")]

        public IActionResult ChangePassword(ChangePasswordRequest req)
        {

            Result result = _identityService.ChangePassword(req);
            if (!result.IsSuccess)
            {
                return BadRequest(new AuthFailedResponse { InnerErrorMessages = new List<string>() { "Incorrect password " } });
            }

            return Ok();
        }
    }
}
