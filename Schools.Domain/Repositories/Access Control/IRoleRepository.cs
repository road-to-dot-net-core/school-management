using PagedList;
using School.Contract.QueryParameters;
using School.Contract.Response.Access_Control.Roles;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Schools.Domain.Repositories.Access_Control
{
    public interface IRoleRepository
    {
        Role FindByKey(Guid id);
        PagedList<RoleResponse> GetAll(QueryParameters queryParameters);
        void Insert(Role entity);
        IEnumerable<Role> FindBy(Expression<Func<Role, bool>> predicate);

        bool Save();
    }
}
