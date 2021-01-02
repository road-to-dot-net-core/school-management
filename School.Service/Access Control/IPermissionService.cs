using CSharpFunctionalExtensions;
using School.Contract.Commands.AccessControl.Permissions;
using School.Contract.Response.Access_Control.Permissions;
using School.Contract.Response.Access_Control.Roles;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Service.Access_Control
{
    public interface IPermissionService
    {
        IEnumerable<PermissionResponse> GetAll();
        bool Insert(InsertPermissionCommand user);
        PermissionResponse GetById(Guid id);

        Result Edit(UpdatePermissionCommand cmd);
        Result Delete(DeletePermissionCommand cmd);

    }
}
