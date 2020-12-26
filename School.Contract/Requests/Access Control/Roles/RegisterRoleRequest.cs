using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Requests.Access_Control.Roles
{
    public class RegisterRoleRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Guid> Permissions { get; set; }

        public RegisterRoleRequest()
        {

        }

        public RegisterRoleRequest(string name, string description, List<Guid> permissions)
        {
            Name = name;
            Description = description;
            Permissions = permissions;
        }
    }
}
