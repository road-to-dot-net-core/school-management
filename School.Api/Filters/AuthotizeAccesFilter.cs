using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using School.Common.Auth;
using School.Service.Access_Control;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace School.Api.Filters
{

    public class AuthorizeAccessFilter : IAuthorizationFilter
    {
        private readonly string _actionName;
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly TokenValidationParameters _tokenValidationParameters;
        private readonly IJwtHandler _jwtHandler;

        public AuthorizeAccessFilter(IUserService userService,
            IHttpContextAccessor httpContextAccessor,
            TokenValidationParameters tokenValidationParameters,
            IJwtHandler jwtHandler,
            string actionName
                                     )
        {
            _actionName = actionName;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
            _tokenValidationParameters = tokenValidationParameters;
            _jwtHandler = jwtHandler;
        }

        public System.Guid GetUserId()
        {
            Guid userId = Guid.Empty;
            try
            {

                userId = System.Guid.Parse(_httpContextAccessor.HttpContext.User.
                    Claims.Single(x => x.Type == "id").Value);
            }
            catch
            {
                userId = Guid.Empty;
            }
            return userId;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string bearerToken = context.HttpContext.Request.Headers["Authorization"];
            if (bearerToken != null)
            {
                bearerToken = bearerToken.Replace("Bearer", "").Trim();
                ClaimsPrincipal validatedToken = _jwtHandler.GetValidPrincipalClaim(bearerToken);
                if (validatedToken != null)
                {
                    if (_jwtHandler.IsTokenExpired(validatedToken))
                    {
                        context.Result = new BadRequestResult();
                        context.HttpContext.Response.Headers["Token-expired"] = "true";
                    
                      //  context.HttpContext.Response.Body = 'TokenExpired';
                        return;
                    }
                    Guid userId = GetUserId();
                    if (userId != Guid.Empty)
                    {
                        // bool isAuthorized = _userService.DoesUseHaveAccessTo(userId, _actionName);
                        bool isAuthorized = true;
                        if (!isAuthorized)
                        {
                            context.Result = new UnauthorizedResult();
                            return;
                        }
                    }
                }
                else
                {
                    context.HttpContext.Response.Headers["Token-Invalid"] = "true";
                    context.Result = new UnauthorizedResult();
                    return;
                }
            }
            else
            {
                context.HttpContext.Response.Headers["Token-absent"] = "true";
                context.Result = new BadRequestResult();
                return;
            }
        }


    }
}
