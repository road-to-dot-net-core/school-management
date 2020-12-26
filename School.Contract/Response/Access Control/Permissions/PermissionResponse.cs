using School.Contract.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Permissions
{
    public class PermissionResponse : ISuccessResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
