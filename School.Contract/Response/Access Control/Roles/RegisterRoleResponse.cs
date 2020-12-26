using School.Contract.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Roles
{
    public class RegisterRoleResponse : ISuccessResponse
    {
        public Guid RoleId { get; set; }
    }
}
