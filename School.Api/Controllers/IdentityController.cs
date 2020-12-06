using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using School.Common.Contracts.Identity;
using School.Contract;
using School.Contract.ApiResults;
using School.Contract.ApiResults.BusinessOperations;
using School.Contract.Requests.Access_Control.Identity;
using School.Service.Access_Control;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        public ActionResult<ApiResult<AuthenticationOperation>> LogIn(LoginRequest req)
        {
            var result = ApiResult<AuthenticationOperation>.CreateResult();
            try
            {
                bool authenticated = _identityService.Authenticate(req);
                if (!authenticated)
                    result.AppendErrorResponse(new AuthFailedResponse()
                    {
                        InnerErrorMessages = new List<string>() { "Login name must be greater than 10 caracters" }
                    });

                if (!result.IsOk)
                    return BadRequest(result.Failure());

                var token = _identityService.IssueJwtToken("", req.Login);
                var apiResult = result.Success(new AuthSuccessResponse()
                {
                    RefreshToken = token.RefreshToken,
                    Token = token.Token
                });

                return Ok(apiResult);
            }
            catch (Exception ex)
            {
                result.AppendErrorResponse(new TechnicalFailureResponse(ex));
                return StatusCode(500, result.Failure());
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
