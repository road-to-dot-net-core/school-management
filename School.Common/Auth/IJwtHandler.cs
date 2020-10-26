
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace School.Common.Auth
{
    public interface IJwtHandler
    {
        JwtToken Create(Guid userId);
        ClaimsPrincipal GetPrincipalClaims(string token);
    }
}
