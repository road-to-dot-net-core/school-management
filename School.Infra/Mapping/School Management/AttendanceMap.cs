using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Schools.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infra.Mapping.School_Management
{
    public class AttendanceMap : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.ToTable("ATTENDANCES");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Notes).HasMaxLength(500);


            builder.Property(aa => aa.CreatedOn).HasColumnName("CreatedOn").HasDefaultValue(DateTime.Now).IsRequired(true);
            builder.Property(aa => aa.CreatedBy).HasColumnName("CreatedBy").HasDefaultValue(null).IsRequired(false);

            builder.Property(aa => aa.UpdatedOn).HasColumnName("UpdatedOn").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.UpdatedBy).HasColumnName("UpdatedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(a => a.Timestamp).IsRowVersion();

            builder.Ignore(aa => aa.Deleted);
            builder.Property(aa => aa.DeleteReason).HasColumnName("DeletReason").HasDefaultValue(null).HasMaxLength(250).IsRequired(false);
            builder.Property(aa => aa.DeletedBy).HasColumnName("DeletedBy").HasDefaultValue(null).IsRequired(false);
            builder.Property(aa => aa.DeletedOn).HasColumnName("DeletedOn").HasDefaultValue(null).IsRequired(false);



            builder.HasOne(a => a.CourseOfferingSession)
                .WithMany()
                .HasForeignKey(a => a.CourseOfferingSessionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Student)
            .WithMany()
            .HasForeignKey(a => a.StudentId)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
