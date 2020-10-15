using System;
using System.Collections.Generic;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class PermissionFeature
    {
        public Guid PermissionId { get; set; }
        public Guid FeatureId { get; set; }
        public byte[] Timestamp { get; private set; }

        public DateTime AssociatedOn { get; set; }
        public virtual Feature Feature { get; set; }
        public virtual Permission Permission { get; set; }

        private PermissionFeature(Guid permissionId, Guid featureId)
        {
            PermissionId = permissionId;
            FeatureId = featureId;
            AssociatedOn = DateTime.Now;
        }
        protected PermissionFeature()
        {

        }
        public static PermissionFeature Create(Guid permissionId, Guid featureId)
        {
            var permissionFeature = new PermissionFeature(permissionId, featureId);
            return permissionFeature;
        }
    }
}
