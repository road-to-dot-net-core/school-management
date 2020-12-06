using School.Contract.ApiResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Contracts.Identity
{
    public class AuthSuccessResponse : ISuccessResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public AuthSuccessResponse()
        {

        }
        
    }
}
