using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class Role:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RolePermission> RolePermissions{ get; set; }
        public Role()
        {

        }
    }
}
