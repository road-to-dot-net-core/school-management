using School.Contract.Results;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Contract.Response.Access_Control.Roles
{
    public class AllRoleResponse : ISuccessResponse, IEnumerable<RoleResponse>
    {
        public IEnumerable<RoleResponse> Roles { get; set; }

        public AllRoleResponse(IEnumerable<RoleResponse> roles)
        {
            Roles = roles;
        }

        public IEnumerator<RoleResponse> GetEnumerator()
        {
            return this.Roles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public class RoleResponse : ISuccessResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
