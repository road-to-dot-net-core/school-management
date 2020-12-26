using PagedList;
using School.Contract.QueryParameters;
using School.Contract.Response.Access_Control.Permissions;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public interface IPermissionService
    {
        PagedList<PermissionResponse> GetAll(QueryParameters queryParameters);
    }
}
