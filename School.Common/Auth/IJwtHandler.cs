using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace School.Common.Auth
{
    public interface IJwtHandler
    {
        JwtToken Create(Guid userId);
        ClaimsPrincipal GetValidPrincipalClaim(string token);
        bool IsTokenExpired(ClaimsPrincipal validatedToken);

    }
}
