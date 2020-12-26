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

        public IEnumerable<PermissionResponse> GetAll()
        {
            return _permissionRepository
                        .GetAll()
                        .Select(p => new PermissionResponse() { Id = p.Id, Name = p.Label, Description = p.Description })
                        .ToList() ;

        }
    }
}
