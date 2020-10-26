using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Requests.Access_Control.Identity
{
    public class RefreshTokenRequest
    {
        public Guid UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
