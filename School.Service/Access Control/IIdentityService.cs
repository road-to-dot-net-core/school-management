using School.Common.Contracts.Identity;
using School.Contract.Requests.Access_Control.Identity;
using School.Contract.Response.Access_Control.Identity;
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
        public JsonWebTokenResponse RefreshToken(RefreshTokenRequest req);
        public JsonWebTokenResponse IssueJwtToken(string id = "", string email = "");
    }
}
