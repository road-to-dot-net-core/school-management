using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;
using System.Threading;

namespace School.Common.Contracts.Identity
{
    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public LoginRequest()
        {

        }   
        public LoginRequest(string login,string password)
        {
            Login = login;
            Password = password;
        }
    }
}
