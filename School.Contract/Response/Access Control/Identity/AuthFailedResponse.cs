using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Contracts.Identity
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
