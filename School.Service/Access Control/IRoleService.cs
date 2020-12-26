using PagedList;
using School.Contract.QueryParameters;
using School.Contract.Response.Access_Control.Roles;
using School.Contract.Response.Roles;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public interface IRoleService
    {
        PagedList<RoleResponse> GetAll(QueryParameters queryParameters);
        RegisterRoleResponse Register(Role role);
    }
}
