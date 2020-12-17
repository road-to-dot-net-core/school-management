using School.Contract.ApiResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Contract.Response.Access_Control.Permissions
{
    public class AllPermissionResponse:ISuccessResponse
    {
        public List<PermissionResponse> Permissions { get; set; }
    }
}
