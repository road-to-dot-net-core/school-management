using School.Contract.ApiResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Roles
{
    public class AllRoleResponse : ISuccessResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
    public class RoleResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
