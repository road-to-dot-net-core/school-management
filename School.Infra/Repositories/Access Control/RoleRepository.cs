using PagedList;
using School.Contract.QueryParameters;
using School.Contract.Response.Access_Control.Roles;
using Schools.Domain.Models.Access_Control;
using Schools.Domain.Repositories.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace School.Infra.Repositories.Access_Control
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AccessControlContext _context;

        public RoleRepository(AccessControlContext context)
        {
            _context = context;
        }
        public IEnumerable<Role> FindBy(Expression<Func<Role, bool>> predicate)
        {
            IQueryable<Role> results = _context.Roles
                                               .Where(predicate);
            return results;
        }

        public Role FindByKey(Guid id)
        {
            var role = _context.Roles.Find(id);
            if (role == null)
                return null;
            _context.Entry(role).Collection(a => a.RolePermissions).Load();

            return role;
        }


        public PagedList<RoleResponse> GetAll(QueryParameters queryParameters)
        {
            var roles = (from x in _context.Roles
                         orderby x.CreatedOn descending
                         select new RoleResponse
                         {
                             Id = x.Id,
                             Name = x.Name,
                             Description = x.Description,
                             IsActive = !x.Deleted
                         });

            return new PagedList<RoleResponse>(roles, queryParameters.PageNumber, queryParameters.PageSize);
        }

        public void Insert(Role entity)
        {
            _context.Roles.Add(entity);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
