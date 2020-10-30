using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schools.Domain.Models.Access_Control
{
    public class Permission : BaseEntity
    {
        public String Label { get; private set; }
        public String Description { get; private set; }

        private readonly List<PermissionFeature> _permissionFeatures = new List<PermissionFeature>();
        public virtual IReadOnlyList<PermissionFeature> PermissionFeatures => _permissionFeatures.ToList();

        public Permission()
        {

        }
        public Permission(string label, string description, List<Guid> features)
        {
            Label = label;
            Description = description;
            UpdateFeatures(features);
        }

        public bool Update(string label, string description, List<Guid> features)
        {
            Label = label;
            Description = description;
            UpdateFeatures(features);
            return true;
        }

        private void UpdateFeatures(List<Guid> features)
        {
            List<Guid> toAdd = features.Where(a => _permissionFeatures.Where(b => b.Feature.Id == a).Count() == 0).ToList();
            List<PermissionFeature> toDelete = _permissionFeatures.Where(a => features.Where(b => b == a.Feature.Id).Count() == 0)
                .ToList();

            if (toDelete.Count() != 0)
                toDelete.ForEach(a => _permissionFeatures.Remove(a));
            if (toAdd.Count() != 0)
                toAdd.ForEach(a => _permissionFeatures.Add(PermissionFeature.Create(this.Id, a)));

        }

    }
}
