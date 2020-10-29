using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Auth
{
    public interface IJwtHandler
    {
        JwtToken Create(Guid userId);
    }
}
