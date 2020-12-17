using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Requests.Access_Control.Permissions
{
    public class DeletePermissionRequest
    {
        public Guid Id { get; set; }
        public string Reason { get; set; }
    }
}
