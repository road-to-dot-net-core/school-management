using PagedList;
using School.Contract.QueryParameters;
using School.Contract.Response.Access_Control.Permissions;
using School.Domain.Repositories.Access_Control;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace School.Infra.Repositories.Access_Control
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly AccessControlContext _context;

        public PermissionRepository(AccessControlContext context)
        {
            _context = context;
        }
        public IEnumerable<Permission> FindBy(Expression<Func<Permission, bool>> predicate)
        {
            IQueryable<Permission> results = _context.Permissions
                                              .Where(predicate);
            return results;
        }

        public Permission FindByKey(Guid id)
        {
            var permission = _context.Permissions.Find(id);
            if (permission == null)
                return null;
            _context.Entry(permission).Collection(a => a.PermissionFeatures).Load();

            return permission;
        }

        public PagedList<PermissionResponse> GetAll(QueryParameters queryParameters)
        {
            return new PagedList<PermissionResponse>(
                                _context.Permissions.Select(p => new PermissionResponse() { Id = p.Id, Name = p.Label, Description = p.Description }),
                        queryParameters.PageNumber, queryParameters.PageSize);
        }

        public void Insert(Permission entity)
        {
            _context.Permissions.Add(entity);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
