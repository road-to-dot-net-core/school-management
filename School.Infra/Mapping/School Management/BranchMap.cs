using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using Schools.Domain.Models;
using Schools.Domain.Models.School_Management;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class BranchMap : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("BRANCHS");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.Description).HasMaxLength(250).IsRequired(false);


            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Ignore(aa => aa.Deleted);
            builder.Property(aa => aa.DeleteReason).HasColumnName("DeletReason").HasDefaultValue(null).HasMaxLength(250).IsRequired(false);
            builder.Property(aa => aa.DeletedBy).HasColumnName("DeletedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.DeletedOn).HasColumnName("DeletedOn").HasDefaultValue(null).IsRequired(false);





        }
    }
}
