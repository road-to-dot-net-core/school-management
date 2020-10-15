using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class Permission:BaseEntity
    {
        public String Label { get; private set; }
        public String Description { get; private set; }

        private readonly List<PermissionFeature> _permissionFeatures = new List<PermissionFeature>();
        public virtual IReadOnlyList<PermissionFeature> PermissionFeatures => _permissionFeatures.ToList();

        public Permission()
        {

        }

    }
}
