using CSharpFunctionalExtensions;
using School.Contract.Commands.AccessControl.Permissions;
using School.Contract.Response.Access_Control.Permissions;
using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;

        public PermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }
        public IEnumerable<PermissionResponse> GetAll()
        {
            return _permissionRepository.GetAll();
        }

        public PermissionResponse GetById(Guid id)
        {
            return _permissionRepository.FindByKey(id);
        }

        public bool Insert(InsertPermissionCommand cmd)
        {
            var permission = new Permission(cmd.Label, cmd.Description, cmd.Features);
            _permissionRepository.Insert(permission);
            return _permissionRepository.Save();
        }
    }
}
