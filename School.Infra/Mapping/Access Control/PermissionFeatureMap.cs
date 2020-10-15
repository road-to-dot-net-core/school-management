using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping.Access_Control
{
    public class PermissionFeatureMap : IEntityTypeConfiguration<PermissionFeature>
    {
        public void Configure(EntityTypeBuilder<PermissionFeature> builder)
        {
            builder.ToTable("PERMISSIONS_FEATURES");

            builder.HasKey(a => new { a.FeatureId, a.PermissionId });


            builder.Property(a => a.Timestamp).IsRowVersion();


            builder.HasOne(a => a.Permission)
                   .WithMany(a => a.PermissionFeatures)
                   .HasForeignKey(a => a.PermissionId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Feature)
                  .WithMany()
                  .HasForeignKey(a => a.FeatureId)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
