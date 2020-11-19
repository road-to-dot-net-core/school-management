using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Common.Auth
{
    public class JwtOptions
    {
        public string SecretKey { get; set; }
        public long ExpiryMinutes { get; set; }
        public string Issuer { get; set; }
        public int RefreshTokenExpiryDays { get; set; }
    }
}
