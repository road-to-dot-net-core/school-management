using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Requests.Access_Control.Identity
{
    public class ChangePasswordRequest
    {
        public Guid Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
