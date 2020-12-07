using School.Contract.Response.Access_Control.Roles;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public interface IRoleService
    {
        IEnumerable<RoleResponse> GetAll();
    }
}
