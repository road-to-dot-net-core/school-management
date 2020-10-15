using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain.Models.Access_Control;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping.Access_Control
{
    public class RolePermissionMap : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable("ROLE_PERMISSIONS");
            builder.HasKey(a => a.Id);
            //builder.HasKey(a => new
            //{
            //    a.PermissionId,
            //    a.RoleId
            //});
            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();


            builder.Property(a => a.AssociatedOn).IsRequired();

            builder.HasOne(a => a.Role)
                            .WithMany(a => a.RolePermissions)
                            .HasForeignKey(a => a.RoleId)
                            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Permission)
                          .WithMany()
                          .HasForeignKey(a => a.PermissionId)
                          .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
