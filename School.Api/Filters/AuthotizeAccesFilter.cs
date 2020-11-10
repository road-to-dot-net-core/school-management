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

        public AuthorizeAccessFilter(IUserService userService,
            IHttpContextAccessor httpContextAccessor,
            TokenValidationParameters tokenValidationParameters,
            string actionName
                                     )
        {
            _actionName = actionName;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
            _tokenValidationParameters = tokenValidationParameters;
        }
        private bool IsJwtWithValidSecurityAlgorithm(SecurityToken validatedToken)
        {
            return (validatedToken is JwtSecurityToken jwtSecurityToken) &&
                   jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                       StringComparison.InvariantCultureIgnoreCase);
        }

        private ClaimsPrincipal GetPrincipalFromToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenValidationParameters = _tokenValidationParameters.Clone();
                tokenValidationParameters.ValidateLifetime = false;
                if (tokenHandler.CanValidateToken)
                {
                    var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);
                    if (!IsJwtWithValidSecurityAlgorithm(validatedToken))
                    {
                        return null;
                    }

                    return principal;
                }
                return null;
            }
            catch
            {
                return null;
            }
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
                ClaimsPrincipal validatedToken = GetPrincipalFromToken(bearerToken);
                if (validatedToken != null)
                {
                    if (IsTokenExipred(validatedToken))
                    {
                        context.Result =new BadRequestResult();
                        context.HttpContext.Response.Headers["Token-expired"]="true";
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
                    context.Result = new UnauthorizedResult();
            }
            else context.Result = new BadRequestResult();
        }
        private bool IsTokenExipred(ClaimsPrincipal validatedToken)
        {
            var expiryDateInseconds =
               long.Parse(validatedToken.Claims.Single(x => x.Type == JwtRegisteredClaimNames.Exp).Value);

            var expiryDateTimeUtc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            expiryDateTimeUtc = expiryDateTimeUtc.AddSeconds(expiryDateInseconds);

            if (expiryDateTimeUtc < DateTime.UtcNow)
            {
                return true;
            }
            return false;
        }


    }
}
