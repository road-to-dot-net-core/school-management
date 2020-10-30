using School.Common.Auth;
using School.Common.Contracts.Identity;
using School.Contract.Requests.Access_Control.Identity;
using School.Contract.Response.Access_Control.Identity;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public interface IIdentityService
    {
        public bool Authenticate(LoginRequest req);
        public void LogOut(LogOutRequest req);
        public bool ChangePassword(ChangePasswordRequest req);
        public JwtToken IssueJwtToken(string id = "", string email = "");

    }
}
