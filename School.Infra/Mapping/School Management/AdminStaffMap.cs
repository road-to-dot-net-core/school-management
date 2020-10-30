using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping.School_Management
{
    public class AdminStaffMap : IEntityTypeConfiguration<AdminStaff>
    {
        public void Configure(EntityTypeBuilder<AdminStaff> builder)
        {
            builder.ToTable("ADMINISTRATION_STAFFS");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.LastName).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.AddressLine).HasMaxLength(255);
            builder.Property(a => a.Notes).HasMaxLength(500);
            builder.Property(a => a.Phone).HasMaxLength(50);


            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();

            builder.Ignore(aa => aa.Deleted);
            builder.Property(aa => aa.DeleteReason).HasColumnName("DeletReason").HasDefaultValue(null).HasMaxLength(250).IsRequired(false);
            builder.Property(aa => aa.DeletedBy).HasColumnName("DeletedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.DeletedOn).HasColumnName("DeletedOn").HasDefaultValue(null).IsRequired(false);


            builder.HasOne(a => a.Organization)
                .WithMany()
                .HasForeignKey(a => a.OrgId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
