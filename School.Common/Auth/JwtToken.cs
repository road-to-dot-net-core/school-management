using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Common.Auth
{
    public class JwtToken
    {
        public string Token { get; set; }
        public long Expires { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string JwtId { get; set; }
        public Guid UserId { get; set; }
    }
}
