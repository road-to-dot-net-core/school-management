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

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public Role()
        {

        }
        public Role(string name, string description, List<Guid> permissions)
        {
            Name = name;
            Description = description;
            CanBeDeleted = true;
            UpdatePermissions(permissions);

        }
        private void UpdatePermissions(List<Guid> permissions)
        {
            List<Guid> toAdd = permissions.Where(a => RolePermissions.Where(b => b.Permission.Id == a).Count() == 0).ToList();
            List<RolePermission> toDelete = RolePermissions.Where(a => permissions.Where(b => b == a.Permission.Id).Count() == 0)
                .ToList();

            if (toDelete.Count() != 0)
                toDelete.ForEach(a => RolePermissions.Remove(a));
            if (toAdd.Count() != 0)
                toAdd.ForEach(a => RolePermissions.Add(RolePermission.Create(this.Id, a)));

        }
    }
}
