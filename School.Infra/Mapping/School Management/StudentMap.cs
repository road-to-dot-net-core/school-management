using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("STUDENTS");

            builder.HasKey(a => a.Id);
            builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.LastName).HasMaxLength(50).IsRequired(true);
            builder.Property(a => a.AddressLine1).HasMaxLength(255);
            builder.Property(a => a.AddressLine2).HasMaxLength(255);
            builder.Property(a => a.Notes).HasMaxLength(500);
            builder.Property(a => a.Phone).HasMaxLength(50);


            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();


            //
            builder.HasOne(a => a.LevelClass)
                   .WithMany(a => a.Students)
                   .HasForeignKey(a => a.LevelClassId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
