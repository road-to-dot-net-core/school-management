using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Requests.Access_Control.Identity
{
    public class UserLoginResponse
    {
        public string RefreshToken { get; set; }
        public string Token { get; set; }

        public UserLoginResponse()
        {

        }
    }
}
