using PagedList;
using School.Contract.QueryParameters;
using School.Contract.Response.Access_Control.Permissions;
using School.Domain.Repositories.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Service.Access_Control
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository)
        {
            this._permissionRepository = permissionRepository;
        }

        public PagedList<PermissionResponse> GetAll(QueryParameters queryParameters)
        {
            return _permissionRepository.GetAll(queryParameters);

        }
    }
}
