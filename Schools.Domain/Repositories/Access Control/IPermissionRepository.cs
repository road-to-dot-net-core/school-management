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
        IEnumerable<Permission> GetAll();
        void Insert(Permission entity);
        IEnumerable<Permission> FindBy(Expression<Func<Permission, bool>> predicate);

        bool Save();
    }
}
