using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace School.Common.Contracts.Identity
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
