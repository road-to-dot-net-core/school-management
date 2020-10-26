using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Contracts.Identity
{
    public class AuthSuccessResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
