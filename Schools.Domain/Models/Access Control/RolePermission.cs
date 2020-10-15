using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class RolePermission:BaseEntity
    {
        public DateTime AssociatedOn { get; set; }
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }


        public Guid PermissionId { get; set; }
        public virtual Permission Permission { get; set; }

        public RolePermission()
        {

        }
        private RolePermission(Guid roleId, Guid permissionId)
        {
            RoleId = roleId;
            PermissionId = permissionId;
            AssociatedOn = DateTime.Now;
        }
        public static RolePermission Create(Guid roleId, Guid permissionId)
        {
            RolePermission userPermission = new RolePermission(roleId, permissionId);
            return userPermission;
        }
    }
}
