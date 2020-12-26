using School.Contract.Results;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Permissions
{
    public class AllPermissionResponse : ISuccessResponse, IEnumerable<PermissionResponse>
    {
        public IEnumerable<PermissionResponse> Permissions { get; set; }

        public AllPermissionResponse(IEnumerable<PermissionResponse> permissions)
        {
            Permissions = permissions;
        }

        public IEnumerator<PermissionResponse> GetEnumerator()
        {
            return this.Permissions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
