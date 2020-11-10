using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class PermissionFeature
    {
        public Guid PermissionId { get; private  set; }
        public Guid FeatureId { get; private set; }
        public byte[] Timestamp { get; private set; }

        public DateTime AssociatedOn { get; private set; }
        public virtual Feature Feature { get; private set; }
        public virtual Permission Permission { get; private set; }

        private PermissionFeature(Guid permissionId, Guid featureId)
        {
            PermissionId = permissionId;
            FeatureId = featureId;
            AssociatedOn = DateTime.Now;
        }
        public PermissionFeature()
        {

        }
        public static PermissionFeature Create(Guid permissionId, Guid featureId)
        {
            var permissionFeature = new PermissionFeature(permissionId, featureId);
            return permissionFeature;
        }
    }
}
