using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Identity
{
    public class JsonWebTokenResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public long Expires { get; set; }
    }
}
