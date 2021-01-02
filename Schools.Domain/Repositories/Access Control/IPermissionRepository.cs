using CSharpFunctionalExtensions;
using School.Contract.Response.Access_Control.Permissions;
using Schools.Domain.Models;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace School.Domain.Repositories.Access_Control
{
    public interface IPermissionRepository
    {
        Permission FindByKey(Guid id);
        PermissionResponse GetById(Guid id);

        IEnumerable<PermissionResponse> GetAll();
        void Insert(Permission entity);

        bool Save();
    }
}
