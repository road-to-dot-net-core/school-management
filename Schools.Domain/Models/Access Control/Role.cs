using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Schools.Domain.Models.Access_Control
{
    public class Role : BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public bool CanBeDeleted { get; private set; }

        private readonly List<RolePermission> _rolePermissions = new List<RolePermission>();
        public virtual IReadOnlyList<RolePermission> RolePermissions  => _rolePermissions.ToList();

        public Role()
        {
        }
        public Role(string name, string description,List<Guid> permissions)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            CanBeDeleted = true;
            UpdatePermissions(permissions);

        }
        private void UpdatePermissions(List<Guid> permissions)
        {
            List<Guid> toAdd = permissions.Where(a => _rolePermissions.Where(b => b.Permission.Id == a).Count() == 0).ToList();
            List<RolePermission> toDelete = _rolePermissions.Where(a => permissions.Where(b => b == a.Permission.Id).Count() == 0)
                                                            .ToList();

            if (toDelete.Count() != 0)
                toDelete.ForEach(a => _rolePermissions.Remove(a));
            if (toAdd.Count() != 0)
                toAdd.ForEach(a => _rolePermissions.Add(RolePermission.Create(this.Id, a)));

        }
    }
}
